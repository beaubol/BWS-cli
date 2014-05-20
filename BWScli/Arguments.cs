using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace BWScli
{
    /// <summary>
    /// Simple command line parser.   
    /// </summary>
    /// <remarks>
    /// This is a very simple argument parser. Just create an instance of
    /// this type with the command line array from the <c>Main</c> method.
    /// It will automatically parse the command line arguments, find all
    /// parameters starting with -, -- or / and all the values linked.
    /// Any value could be separated from the parameter with a : or a =.
    /// The parser also supports standalone params, like file paths. 
    /// </remarks>
    /// <example>
    /// Here is an example on how to retrieve the command line arguments.
    /// <code>
    ///     static void Main(string[] args)
    ///     {
    ///          Arguments arguments = new Arguments(args);
    ///
    ///          if (arguments["Height"] != null)
    ///               Console.WriteLine( "Height: " + arguments["Height"] );
    ///          else
    ///               Console.WriteLine( "Height is not defined !" );
    ///
    ///          if (arguments[0] != null)
    ///               Console.WriteLine( "Standalone parameter: " + arguments[0] );
    ///          else
    ///               Console.WriteLine( "No standalone parameter ..." );
    ///     }
    /// </code>
    /// </example>
    public class Arguments
    {
        /// <summary>
        /// List of prefixed arguments
        /// </summary>
        private StringDictionary prefixedParams = new StringDictionary();

        /// <summary>
        /// List of standalone arguments
        /// </summary>
        private List<string> anonymousParams = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Arguments"/> class to parse command lines.
        /// </summary>
        /// <param name="args">The command line to parse.</param>
        public Arguments(string[] args)
        {
            Regex spliter = new Regex(@"^([/-]|--){1}(?<name>\w+)([:=])?(?<value>.+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            char[] trimChars = { '"', '\'' };
            Match part;

            foreach (string arg in args)
            {
                part = spliter.Match(arg);
                if (part.Success)
                    prefixedParams[part.Groups["name"].Value] = part.Groups["value"].Value.Trim(trimChars);
                else
                    anonymousParams.Add(arg);
            }
        }

        /// <summary>
        /// Gets the array of anonymous parameters, i.e. standalone arguments.
        /// </summary>
        public string[] AnonymousParams
        {
            get
            {
                return anonymousParams.ToArray();
            }
        }

        /// <summary>
        /// Retrieves the parameter with the specified name.
        /// </summary>
        /// <param name="name">
        /// The name of the parameter. The name is case insensitive.
        /// </param>
        /// <returns>
        /// The parameter or <c>null</c> if it can not be found.
        /// </returns>
        public string this[string name]
        {
            get
            {
                return prefixedParams[name];
            }
        }

        /// <summary>
        /// Retrieves the <paramref name="i"/>th standalone parameter.
        /// </summary>
        /// <param name="i">The index of the requested standalone argument.</param>
        /// <returns>
        /// The requested parameter or <c>null</c> if no parameter is at
        /// position <paramref name="i"/>.
        /// </returns>
        public string this[int i]
        {
            get
            {
                return anonymousParams.Count > i ? anonymousParams[i] : null;
            }
        }
    }
}
