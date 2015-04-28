using BWScli.BWS;
using System;
using System.Linq;

namespace BWScli
{
    class Program
    {
        static void Main(string[] args)
        {
            // parse the command-line
            var arguments = new Arguments(args);
            if (arguments["help"] != null || arguments["h"] != null)
            {
                Usage();
                return;
            }

            BiometricClassID bcid;
            bool livedetection, autoenrollment, icao;
            Sample[] samples;
            try
            {
                bcid = ParseBCID(arguments["bcid"]);
                livedetection = (arguments["livedetection"] != null || arguments["l"] != null);
                autoenrollment = (arguments["autoenrollment"] != null || arguments["a"] != null);
                icao = arguments["icao"] != null;

                // load the samples from the given files
                samples = arguments.AnonymousParams.Select(file => new Sample
                {
                    Trait = file.EndsWith("wav", StringComparison.OrdinalIgnoreCase) ? Trait.Voice : Trait.Face,
                    Data = System.IO.File.ReadAllBytes(file)
                }).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not parse/load arguments:");
                Console.WriteLine(e.Message);
                Usage();
                return;
            }

            BioIDWebServiceClient client = null;
            try
            {
                // connect to  BWS
                client = new BioIDWebServiceClient();

                // go for the commands:
                // - Enrollment
                if (arguments["enroll"] != null || arguments["e"] != null)
                {
                    if (bcid == null) { Usage(); return; }
                    var flags = EnrollmentFlags.None;
                    if (livedetection) flags |= EnrollmentFlags.LiveFaceDetection;
                    Console.WriteLine("Enrollment of class {0}/{1}/{2} with {3} samples (Flags: {4}) ...", bcid.Storage, bcid.Partition, bcid.ClassID, samples.Length, flags);
                    string messages;
                    bool success = client.Enroll(bcid, samples, flags, out messages);
                    Console.WriteLine(success ? "... SUCCEEDED." : "... FAILED!!!");
                    Console.WriteLine(messages);
                }
                // - Verification
                else if (arguments["verify"] != null || arguments["v"] != null)
                {
                    if (bcid == null || samples.Length == 0) { Usage(); return; }
                    var flags = ClassificationFlags.None;
                    if (livedetection) flags |= ClassificationFlags.LiveFaceDetection;
                    if (autoenrollment) flags |= ClassificationFlags.AutoEnrollment;
                    Console.WriteLine("Verification of class {0}/{1}/{2} with {3} samples (Flags: {4}) ...", bcid.Storage, bcid.Partition, bcid.ClassID, samples.Length, flags);
                    string messages;
                    bool success = client.Verify(bcid, samples, flags, out messages);
                    Console.WriteLine(success ? "... SUCCEEDED." : "... FAILED!!!");
                    Console.WriteLine(messages);
                }
                // - Identification
                else if (arguments["identify"] != null || arguments["i"] != null)
                {
                    if (bcid == null || samples.Length == 0) { Usage(); return; }
                    var flags = ClassificationFlags.None;
                    if (livedetection) flags |= ClassificationFlags.LiveFaceDetection;
                    Console.WriteLine("Identification on partition {0}/{1} with {2} samples (Flags: {3}) ...", bcid.Storage, bcid.Partition, samples.Length, flags);
                    string messages;
                    ScoredClass[] matches;
                    bool success = client.Identify(bcid, samples, flags, 20, out matches, out messages);
                    Console.WriteLine(success ? "... SUCCEEDED." : "... FAILED!!!");
                    Console.WriteLine(messages);
                    Console.WriteLine("Identification Results (BCID: Score):");
                    if (matches != null)
                        foreach (ScoredClass score in matches.Where(score => score != null))
                            Console.WriteLine("    {0}/{1}/{2}: {3}", score.Storage, score.Partition, score.ClassID, score.Score);
                }
                // - QualityCheck
                else if (arguments["check"] != null || arguments["c"] != null)
                {
                    if (samples.Length == 0) { Usage(); return; }
                    var flags = TestFlags.ExtractTokenData;
                    if (icao) flags = TestFlags.ICAOChecks;
                    Console.WriteLine("QualityCheck of {0} samples (Flags: {1}, Issuer: {2}) ...", samples.Length, flags, "BioID");
                    string messages;
                    Sample[] processedSamples;
                    bool success = client.QualityCheck(samples, flags, "BioID", out processedSamples, out messages);
                    Console.WriteLine(success ? "... SUCCEEDED." : "... FAILED!!!");
                    Console.WriteLine(messages);
                }
                // - Delete
                else if (arguments["delete"] != null || arguments["d"] != null)
                {
                    if (bcid == null) { Usage(); return; }
                    Console.WriteLine("Deleting class {0}/{1}/{2} ...", bcid.Storage, bcid.Partition, bcid.ClassID);
                    bool success = client.DeleteClass(bcid);
                    Console.WriteLine(success ? "... SUCCEEDED." : "... FAILED!!!");
                }
                // - Status
                else
                {
                    Console.WriteLine("Fetching Status ...");
                    string status;
                    bool success = client.Status(out status);
                    Console.WriteLine(success ? "... SUCCEEDED." : "... FAILED!!!");
                    Console.WriteLine(status);
                }
            }
            catch (System.ServiceModel.FaultException<BioIDWebServiceFault> bioidFault)
            {
                Console.WriteLine("BioIDWebServiceFault {0}:", bioidFault.Detail.Code);
                Console.WriteLine(bioidFault.Detail.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (null != client)
                    client.Close();
            }
        }

        /// <summary>
        /// Creates a <see cref="BiometricClassID"/> (BCID) from its string representation.
        /// </summary>
        /// <param name="value">The string encoding to convert to a BCID.</param>
        /// <returns>
        /// A newly created <see cref="BiometricClassID"/>, when the <paramref name="value"/>
        /// contained a valid representation of a BCID, otherwise a <c>null</c> reference.
        /// </returns>
        public static BiometricClassID ParseBCID(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;
            string str = value.Trim();
            if (str.StartsWith("urn:bcid:", StringComparison.InvariantCultureIgnoreCase))
                str = str.Substring(9);
            string[] components = str.Split(new char[] { '/', '.', ':' });
            if (components.Length != 3)
                return null;
            var bcid = new BiometricClassID();
            bcid.Storage = components[0];
            int i;
            if (!int.TryParse(components[1], out i))
                return null;
            bcid.Partition = i;
            if (!int.TryParse(components[2], out i))
                return null;
            bcid.ClassID = i;
            return bcid;
        }

        /// <summary>
        /// The usage description for the BWS Cli.
        /// </summary>
        private static void Usage()
        {
            Console.Error.Write(@"
BWScli is a simple BWS command line interface that executes a single command
at a BioID Web Service. The target BWS is specified in the application config
file 'BWScli.exe.config'. Please ensure that client certificate and endpoint
address are correct in this file!

Syntax: 
      BWScli /help
      BWScli [/status] |
            /enroll /bcid:<BCID> [/livedetection] {<sample>} |
            /verify /bcid:<BCID> [/l] [/a] <sample> {<sample>} |
            /identify /bcid:<BCID> [/livedetection] <sample> {<sample>} |
            /check [/icao] <sample> {<sample>} |
            /delete /bcid:<BCID>

Options:

    /help (or /h)
            Show this usage information of the BWS command line interface.

    /bcid:<BCID>
            The BCID to use. Has the format: storage/partition/classId
    /livedetection (or /l)
            Perform a face live detection. Default: no
    /autoenrollment (or /a)
            Enables automatic enrollment with the verification. Default: no
    /icao
            Use ICAO check instead of Extract Token-Data.

Arguments:

    <sample>
            Samples are specified as files. Supported are 'wav' files, which
            are assumed to represent the voice trait, all aother files are
            supposed to be face image files.

Commands:

    /status (or /s)
            Fetch the Status from the BWS. This is the default command.
    /enroll (or /e)
            Perform a (Re-)Enrollment at the BWS.
            Supports /livedetection.
    /verify (or /v)
            Perform a Verification at the BWS. Requires one or more <sample>s.
            Supports /livedetection and /autoenrollment.
    /identify (or /i)
            Perform an Identification at the BWS. Requires one or more
            <sample>s. Supports /livedetection.
    /check (or /c)
            Perform a QualityCheck at the BWS. Requires one or more <sample>s.
            Supports /icao.
    /delete (or /d)
            Delete a class at the BWS.                

");
        }
    }
}
