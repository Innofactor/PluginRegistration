namespace Xrm.Sdk.PluginRegistration.Entities.Transformation
{
    using Microsoft.Xrm.Sdk;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Magic
    {
        public static T Do<T>(Entity entity)
            where T: Entity
        {
            return default(T);
        }
    }
}
