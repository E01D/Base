using NUnit.Framework;
using Root.Coding.Code.Domains.E01D;

namespace Root.Testing.Tests.Domains.E01D
{
    [TestFixture]
    public class XNewTests
    {
        [Test]
        public void ApiIsNotNull()
        {
            Assert.IsNotNull(XNew.Api);
        }
    }
}
