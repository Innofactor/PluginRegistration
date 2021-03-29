using Microsoft.Xrm.Sdk.Query;

namespace Xrm.Sdk.PluginRegistration.Models
{
    public static partial class Solution
    {
        #region Public Fields

        public static ColumnSet Columns = new ColumnSet("solutionid", "friendlyname", "version", "publisherid", "uniquename");

        #endregion Public Fields
    }
}