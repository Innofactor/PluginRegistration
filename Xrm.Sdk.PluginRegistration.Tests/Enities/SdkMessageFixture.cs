namespace Xrm.Sdk.PluginRegistration.Tests.Enities
{
    using Entities;
    using Entities.Transformation;
    using Microsoft.Xrm.Sdk;
    using NUnit.Framework;
    using System;

    [TestFixture]
    class SdkMessageFixture
    {
        [Test]
        public void CheckLogicalName()
        {
            // Arrange
            var lateBound = new Entity("sdkmessage");

            // Act
            var earlyBound = Magic.Cast<SdkMessage>(lateBound);

            // Assert
            Assert.That(earlyBound.LogicalName == lateBound.LogicalName);
        }

        [Test]
        public void CheckBoolAttribute()
        {
            // Arrange
            var lateBound = new Entity("sdkmessage");
            lateBound.Attributes.Add("autotransact", true);

            // Act
            var earlyBound = Magic.Cast<SdkMessage>(lateBound);

            // Assert
            Assert.That(earlyBound.AutoTransact == (bool?)lateBound.Attributes["autotransact"]);
        }

        [Test]
        public void CheckDateTimeAttribute()
        {
            // Arrange
            var lateBound = new Entity("sdkmessage");
            lateBound.Attributes.Add("createdon", DateTime.Today);

            // Act
            var earlyBound = Magic.Cast<SdkMessage>(lateBound);

            // Assert
            Assert.That(earlyBound.CreatedOn.Value.Day == ((DateTime?)lateBound.Attributes["createdon"]).Value.Day);
        }
    }
}
