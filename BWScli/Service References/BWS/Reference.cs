﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BWScli.BWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BiometricClassID", Namespace="http://schemas.bioid.com/2011/12/bws")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BWScli.BWS.ScoredClass))]
    public partial class BiometricClassID : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClassIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PartitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StorageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClassID {
            get {
                return this.ClassIDField;
            }
            set {
                if ((this.ClassIDField.Equals(value) != true)) {
                    this.ClassIDField = value;
                    this.RaisePropertyChanged("ClassID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Partition {
            get {
                return this.PartitionField;
            }
            set {
                if ((this.PartitionField.Equals(value) != true)) {
                    this.PartitionField = value;
                    this.RaisePropertyChanged("Partition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Storage {
            get {
                return this.StorageField;
            }
            set {
                if ((object.ReferenceEquals(this.StorageField, value) != true)) {
                    this.StorageField = value;
                    this.RaisePropertyChanged("Storage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScoredClass", Namespace="http://schemas.bioid.com/2011/12/bws")]
    [System.SerializableAttribute()]
    public partial class ScoredClass : BWScli.BWS.BiometricClassID {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ScoreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Score {
            get {
                return this.ScoreField;
            }
            set {
                if ((this.ScoreField.Equals(value) != true)) {
                    this.ScoreField = value;
                    this.RaisePropertyChanged("Score");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sample", Namespace="http://schemas.bioid.com/2011/12/bws")]
    [System.SerializableAttribute()]
    public partial class Sample : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BWScli.BWS.Trait TraitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tag {
            get {
                return this.TagField;
            }
            set {
                if ((object.ReferenceEquals(this.TagField, value) != true)) {
                    this.TagField = value;
                    this.RaisePropertyChanged("Tag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BWScli.BWS.Trait Trait {
            get {
                return this.TraitField;
            }
            set {
                if ((this.TraitField.Equals(value) != true)) {
                    this.TraitField = value;
                    this.RaisePropertyChanged("Trait");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="Trait", Namespace="http://schemas.bioid.com/2011/12/bws")]
    public enum Trait : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Face = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ocular = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Voice = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fingerprint = 8,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="EnrollmentFlags", Namespace="http://schemas.bioid.com/2011/12/bws")]
    public enum EnrollmentFlags : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OverwriteExisitingData = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LiveFaceDetection = 16,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
    [System.SerializableAttribute()]
    public partial class BioIDWebServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.FlagsAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClassificationFlags", Namespace="http://schemas.bioid.com/2011/12/bws")]
    public enum ClassificationFlags : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LiveFaceDetection = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AutoEnrollment = 16,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TestFlags", Namespace="http://schemas.bioid.com/2011/12/bws")]
    public enum TestFlags : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ExtractTokenData = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ICAOChecks = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.bioid.com/2011/12/bws", ConfigurationName="BWS.IBioIDWebService")]
    public interface IBioIDWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Enroll", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/EnrollResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BWScli.BWS.BioIDWebServiceFault), Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/EnrollBioIDWebServiceFaultFault" +
            "", Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
        BWScli.BWS.EnrollResponse Enroll(BWScli.BWS.EnrollRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Enroll", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/EnrollResponse")]
        System.Threading.Tasks.Task<BWScli.BWS.EnrollResponse> EnrollAsync(BWScli.BWS.EnrollRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Verify", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/VerifyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BWScli.BWS.BioIDWebServiceFault), Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/VerifyBioIDWebServiceFaultFault" +
            "", Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
        BWScli.BWS.VerifyResponse Verify(BWScli.BWS.VerifyRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Verify", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/VerifyResponse")]
        System.Threading.Tasks.Task<BWScli.BWS.VerifyResponse> VerifyAsync(BWScli.BWS.VerifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Identify", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/IdentifyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BWScli.BWS.BioIDWebServiceFault), Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/IdentifyBioIDWebServiceFaultFau" +
            "lt", Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
        BWScli.BWS.IdentifyResponse Identify(BWScli.BWS.IdentifyRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Identify", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/IdentifyResponse")]
        System.Threading.Tasks.Task<BWScli.BWS.IdentifyResponse> IdentifyAsync(BWScli.BWS.IdentifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/QualityCheck", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/QualityCheckResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BWScli.BWS.BioIDWebServiceFault), Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/QualityCheckBioIDWebServiceFaul" +
            "tFault", Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
        BWScli.BWS.QualityCheckResponse QualityCheck(BWScli.BWS.QualityCheckRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/QualityCheck", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/QualityCheckResponse")]
        System.Threading.Tasks.Task<BWScli.BWS.QualityCheckResponse> QualityCheckAsync(BWScli.BWS.QualityCheckRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Status", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/StatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BWScli.BWS.BioIDWebServiceFault), Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/StatusBioIDWebServiceFaultFault" +
            "", Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
        BWScli.BWS.StatusResponse Status(BWScli.BWS.StatusRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/Status", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/StatusResponse")]
        System.Threading.Tasks.Task<BWScli.BWS.StatusResponse> StatusAsync(BWScli.BWS.StatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/DeleteClass", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/DeleteClassResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BWScli.BWS.BioIDWebServiceFault), Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/DeleteClassBioIDWebServiceFault" +
            "Fault", Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
        bool DeleteClass(BWScli.BWS.BiometricClassID classId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/DeleteClass", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/DeleteClassResponse")]
        System.Threading.Tasks.Task<bool> DeleteClassAsync(BWScli.BWS.BiometricClassID classId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/IsEnrolled", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/IsEnrolledResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BWScli.BWS.BioIDWebServiceFault), Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/IsEnrolledBioIDWebServiceFaultF" +
            "ault", Name="BioIDWebServiceFault", Namespace="http://schemas.bioid.com/2011/12/bws")]
        bool IsEnrolled(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Trait trait);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.bioid.com/2011/12/bws/IBioIDWebService/IsEnrolled", ReplyAction="http://www.bioid.com/2011/12/bws/IBioIDWebService/IsEnrolledResponse")]
        System.Threading.Tasks.Task<bool> IsEnrolledAsync(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Trait trait);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Enroll", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class EnrollRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public BWScli.BWS.BiometricClassID classId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public BWScli.BWS.Sample[] samples;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=2)]
        public BWScli.BWS.EnrollmentFlags flags;
        
        public EnrollRequest() {
        }
        
        public EnrollRequest(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Sample[] samples, BWScli.BWS.EnrollmentFlags flags) {
            this.classId = classId;
            this.samples = samples;
            this.flags = flags;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EnrollResponse", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class EnrollResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public bool EnrollResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public string messages;
        
        public EnrollResponse() {
        }
        
        public EnrollResponse(bool EnrollResult, string messages) {
            this.EnrollResult = EnrollResult;
            this.messages = messages;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Verify", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class VerifyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public BWScli.BWS.BiometricClassID classId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public BWScli.BWS.Sample[] samples;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=2)]
        public BWScli.BWS.ClassificationFlags flags;
        
        public VerifyRequest() {
        }
        
        public VerifyRequest(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Sample[] samples, BWScli.BWS.ClassificationFlags flags) {
            this.classId = classId;
            this.samples = samples;
            this.flags = flags;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VerifyResponse", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class VerifyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public bool VerifyResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public string messages;
        
        public VerifyResponse() {
        }
        
        public VerifyResponse(bool VerifyResult, string messages) {
            this.VerifyResult = VerifyResult;
            this.messages = messages;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Identify", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class IdentifyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public BWScli.BWS.BiometricClassID partitionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public BWScli.BWS.Sample[] samples;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=2)]
        public BWScli.BWS.ClassificationFlags flags;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=3)]
        public int maxResults;
        
        public IdentifyRequest() {
        }
        
        public IdentifyRequest(BWScli.BWS.BiometricClassID partitionId, BWScli.BWS.Sample[] samples, BWScli.BWS.ClassificationFlags flags, int maxResults) {
            this.partitionId = partitionId;
            this.samples = samples;
            this.flags = flags;
            this.maxResults = maxResults;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IdentifyResponse", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class IdentifyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public bool IdentifyResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public BWScli.BWS.ScoredClass[] matches;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=2)]
        public string messages;
        
        public IdentifyResponse() {
        }
        
        public IdentifyResponse(bool IdentifyResult, BWScli.BWS.ScoredClass[] matches, string messages) {
            this.IdentifyResult = IdentifyResult;
            this.matches = matches;
            this.messages = messages;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="QualityCheck", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class QualityCheckRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public BWScli.BWS.Sample[] samples;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public BWScli.BWS.TestFlags flags;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=2)]
        public string issuer;
        
        public QualityCheckRequest() {
        }
        
        public QualityCheckRequest(BWScli.BWS.Sample[] samples, BWScli.BWS.TestFlags flags, string issuer) {
            this.samples = samples;
            this.flags = flags;
            this.issuer = issuer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="QualityCheckResponse", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class QualityCheckResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public bool QualityCheckResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public BWScli.BWS.Sample[] processedSamples;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=2)]
        public string messages;
        
        public QualityCheckResponse() {
        }
        
        public QualityCheckResponse(bool QualityCheckResult, BWScli.BWS.Sample[] processedSamples, string messages) {
            this.QualityCheckResult = QualityCheckResult;
            this.processedSamples = processedSamples;
            this.messages = messages;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Status", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class StatusRequest {
        
        public StatusRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StatusResponse", WrapperNamespace="http://www.bioid.com/2011/12/bws", IsWrapped=true)]
    public partial class StatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=0)]
        public bool StatusResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.bioid.com/2011/12/bws", Order=1)]
        public string status;
        
        public StatusResponse() {
        }
        
        public StatusResponse(bool StatusResult, string status) {
            this.StatusResult = StatusResult;
            this.status = status;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBioIDWebServiceChannel : BWScli.BWS.IBioIDWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BioIDWebServiceClient : System.ServiceModel.ClientBase<BWScli.BWS.IBioIDWebService>, BWScli.BWS.IBioIDWebService {
        
        public BioIDWebServiceClient() {
        }
        
        public BioIDWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BioIDWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BioIDWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BioIDWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BWScli.BWS.EnrollResponse BWScli.BWS.IBioIDWebService.Enroll(BWScli.BWS.EnrollRequest request) {
            return base.Channel.Enroll(request);
        }
        
        public bool Enroll(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Sample[] samples, BWScli.BWS.EnrollmentFlags flags, out string messages) {
            BWScli.BWS.EnrollRequest inValue = new BWScli.BWS.EnrollRequest();
            inValue.classId = classId;
            inValue.samples = samples;
            inValue.flags = flags;
            BWScli.BWS.EnrollResponse retVal = ((BWScli.BWS.IBioIDWebService)(this)).Enroll(inValue);
            messages = retVal.messages;
            return retVal.EnrollResult;
        }
        
        public System.Threading.Tasks.Task<BWScli.BWS.EnrollResponse> EnrollAsync(BWScli.BWS.EnrollRequest request) {
            return base.Channel.EnrollAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BWScli.BWS.VerifyResponse BWScli.BWS.IBioIDWebService.Verify(BWScli.BWS.VerifyRequest request) {
            return base.Channel.Verify(request);
        }
        
        public bool Verify(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Sample[] samples, BWScli.BWS.ClassificationFlags flags, out string messages) {
            BWScli.BWS.VerifyRequest inValue = new BWScli.BWS.VerifyRequest();
            inValue.classId = classId;
            inValue.samples = samples;
            inValue.flags = flags;
            BWScli.BWS.VerifyResponse retVal = ((BWScli.BWS.IBioIDWebService)(this)).Verify(inValue);
            messages = retVal.messages;
            return retVal.VerifyResult;
        }
        
        public System.Threading.Tasks.Task<BWScli.BWS.VerifyResponse> VerifyAsync(BWScli.BWS.VerifyRequest request) {
            return base.Channel.VerifyAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BWScli.BWS.IdentifyResponse BWScli.BWS.IBioIDWebService.Identify(BWScli.BWS.IdentifyRequest request) {
            return base.Channel.Identify(request);
        }
        
        public bool Identify(BWScli.BWS.BiometricClassID partitionId, BWScli.BWS.Sample[] samples, BWScli.BWS.ClassificationFlags flags, int maxResults, out BWScli.BWS.ScoredClass[] matches, out string messages) {
            BWScli.BWS.IdentifyRequest inValue = new BWScli.BWS.IdentifyRequest();
            inValue.partitionId = partitionId;
            inValue.samples = samples;
            inValue.flags = flags;
            inValue.maxResults = maxResults;
            BWScli.BWS.IdentifyResponse retVal = ((BWScli.BWS.IBioIDWebService)(this)).Identify(inValue);
            matches = retVal.matches;
            messages = retVal.messages;
            return retVal.IdentifyResult;
        }
        
        public System.Threading.Tasks.Task<BWScli.BWS.IdentifyResponse> IdentifyAsync(BWScli.BWS.IdentifyRequest request) {
            return base.Channel.IdentifyAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BWScli.BWS.QualityCheckResponse BWScli.BWS.IBioIDWebService.QualityCheck(BWScli.BWS.QualityCheckRequest request) {
            return base.Channel.QualityCheck(request);
        }
        
        public bool QualityCheck(BWScli.BWS.Sample[] samples, BWScli.BWS.TestFlags flags, string issuer, out BWScli.BWS.Sample[] processedSamples, out string messages) {
            BWScli.BWS.QualityCheckRequest inValue = new BWScli.BWS.QualityCheckRequest();
            inValue.samples = samples;
            inValue.flags = flags;
            inValue.issuer = issuer;
            BWScli.BWS.QualityCheckResponse retVal = ((BWScli.BWS.IBioIDWebService)(this)).QualityCheck(inValue);
            processedSamples = retVal.processedSamples;
            messages = retVal.messages;
            return retVal.QualityCheckResult;
        }
        
        public System.Threading.Tasks.Task<BWScli.BWS.QualityCheckResponse> QualityCheckAsync(BWScli.BWS.QualityCheckRequest request) {
            return base.Channel.QualityCheckAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BWScli.BWS.StatusResponse BWScli.BWS.IBioIDWebService.Status(BWScli.BWS.StatusRequest request) {
            return base.Channel.Status(request);
        }
        
        public bool Status(out string status1) {
            BWScli.BWS.StatusRequest inValue = new BWScli.BWS.StatusRequest();
            BWScli.BWS.StatusResponse retVal = ((BWScli.BWS.IBioIDWebService)(this)).Status(inValue);
            status1 = retVal.status;
            return retVal.StatusResult;
        }
        
        public System.Threading.Tasks.Task<BWScli.BWS.StatusResponse> StatusAsync(BWScli.BWS.StatusRequest request) {
            return base.Channel.StatusAsync(request);
        }
        
        public bool DeleteClass(BWScli.BWS.BiometricClassID classId) {
            return base.Channel.DeleteClass(classId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClassAsync(BWScli.BWS.BiometricClassID classId) {
            return base.Channel.DeleteClassAsync(classId);
        }
        
        public bool IsEnrolled(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Trait trait) {
            return base.Channel.IsEnrolled(classId, trait);
        }
        
        public System.Threading.Tasks.Task<bool> IsEnrolledAsync(BWScli.BWS.BiometricClassID classId, BWScli.BWS.Trait trait) {
            return base.Channel.IsEnrolledAsync(classId, trait);
        }
    }
}
