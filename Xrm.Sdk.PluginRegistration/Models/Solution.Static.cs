using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Xrm.Sdk.PluginRegistration.Models
{
    public partial class Solution
    {
        #region Public Fields

        public static ColumnSet Columns = new ColumnSet("solutionid", "friendlyname", "version", "publisherid", "uniquename");

        #endregion Public Fields

        #region Public Constructors

        public Solution(Entity record)
        {
            Record = record;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Prefix => Record.GetAttributeValue<AliasedValue>("publisher.customizationprefix")?.Value?.ToString();
        public Entity Record { get; }

        #endregion Public Properties

        #region Public Methods

        public override string ToString()
        {
            return Record.GetAttributeValue<string>("friendlyname");
        }

        #endregion Public Methods
    }
}