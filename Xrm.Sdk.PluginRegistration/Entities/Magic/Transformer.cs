namespace Xrm.Sdk.PluginRegistration.Entities.Magic
{
    using Microsoft.Xrm.Sdk;

    public class Transformer : Entity
    {
        /// <summary>
        /// Constructor compatible with generated early-bound entitites
        /// </summary>
        /// <param name="entityName"></param>
        public Transformer(string entityName)
            :base(entityName)
        {
        }

        /// <summary>
        /// Constructor that transforms late-bound classes to early-bound ones
        /// </summary>
        /// <param name="entity"></param>
        public Transformer(Entity entity)
            :base(entity.LogicalName)
        {

        }
    }
}
