namespace Xrm.Sdk.PluginRegistration.Entities
{
    using System.CodeDom.Compiler;
    using System.Runtime.Serialization;

    [DataContract()]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public enum SdkMessageProcessingStepState
    {
        [EnumMember()]
        Enabled = 0,

        [EnumMember()]
        Disabled = 1,
    }
}