namespace Xrm.Sdk.PluginRegistration.Tests.Enities
{
    using Entities;
    using Entities.Transformation;
    using Microsoft.Xrm.Sdk;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    class SdkMessageFixture
    {
        [Test]
        public void CheckLogicalName()
        {
            // Arrange
            var lateBound = new Entity("sdkmessage");

            // Act
            var earlyBound = Magic.Do<SdkMessage>(lateBound);

            // Assert
            Assert.That(earlyBound.LogicalName == lateBound.LogicalName);
        }
    }
}
