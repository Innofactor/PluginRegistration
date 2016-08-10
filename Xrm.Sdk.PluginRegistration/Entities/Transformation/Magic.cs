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
        public static T Cast<T>(Entity entity)
            where T: Entity
        {
            var type = typeof(T);

            var instance = (T)Activator.CreateInstance(typeof(T));
            
            foreach (var property in type.GetProperties().Where(x => x.IsDefined(typeof(AttributeLogicalNameAttribute), false)))
            {
                var attributeName = ((AttributeLogicalNameAttribute)property.GetCustomAttributes(false).FirstOrDefault()).LogicalName;

                if (entity.Attributes.ContainsKey(attributeName))
                {
                    property.SetValue(instance, entity[attributeName]);
                }
            }

            return instance;
        }
    }
}
