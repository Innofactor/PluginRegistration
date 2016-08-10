namespace Xrm.Sdk.PluginRegistration.Entities.Transformation
{
    using Microsoft.Xrm.Sdk;
    using System;

    public static class Magic
    {
        public static T CastTo<T>(Entity entity)
            where T: Entity
        {
            var instance = (T)Activator.CreateInstance(typeof(T));

            if (instance != null)
            {
                instance.Attributes = entity.Attributes;
            }
            
            return instance;
        }
    }
}
