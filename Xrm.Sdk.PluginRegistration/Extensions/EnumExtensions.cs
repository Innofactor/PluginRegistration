namespace Xrm.Sdk.PluginRegistration.Extensions
{
    using System;
    using System.ComponentModel;

    public static class EnumExtensions
    {
        #region Public Methods

        /// <summary>
        /// Returns the description attribute on enum value, if that's not available, it returns the name
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            if (name != null)
            {
                var field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                    else
                    {
                        return name;
                    }
                }
            }
            return null;
        }

        #endregion Public Methods
    }
}