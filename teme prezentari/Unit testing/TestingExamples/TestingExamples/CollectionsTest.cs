using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExamples
{
    [TestFixture]
    internal class CollectionsTest
    {
        [Test]
        public void TestCollectionAssertions()
        {
            var names = new[] { "Sarah", "Amrit", "Amanda", "Sarah" };

            Assert.That(names, Has.Exactly(4).Items); // pass
            Assert.That(names, Is.Empty); // fail
            Assert.That(names, Is.Not.Empty); // pass
            Assert.That(names, Is.Unique); // fail - 2 Sarah items exist
            Assert.That(names, Contains.Item("Sarah")); // pass

            // Alternative syntax
            Assert.That(names, Does.Contain("Sarah")); // pass
            Assert.That(names, Does.Not.Contain("Arnold")); // pass

            Assert.That(names, Has.Exactly(1).EqualTo("Sarah")); // fail
            Assert.That(names, Has.Exactly(2).EqualTo("Sarah")); // pass
            Assert.That(names, Has.Exactly(2).EqualTo("Sarah")
                .And.Exactly(1).EqualTo("Amrit")); // pass

            Assert.That(names, Is.All.Not.Null); // pass
            Assert.That(names, Is.All.Contains("a")); // fail lowercase a
            Assert.That(names, Is.All.Contains("a").IgnoreCase); // pass
            Assert.That(names, Is.All.Matches<string>(name => name.ToUpperInvariant().Contains("A"))); // pass
            Assert.That(names, Is.All.Matches<string>(name => name.Length > 4)); // pass

            Assert.That(names, Has.Exactly(1).Matches<string>(name => name.Contains("mri"))); // pass
            Assert.That(names, Has.Exactly(1).Matches<string>(name => name.Contains("ara"))); // fail (2 Sarah items exist)
        }
    }
}
