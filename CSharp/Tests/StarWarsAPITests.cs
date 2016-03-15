using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class StarWarsAPITests
    {
        [Test]
        public void TestThat_WeCanReceiveSomeOutput()
        {
            var sut = new MikesThing();

            var output = sut.GetFilms();

            Assert.NotNull(output);
        }
    }
}
