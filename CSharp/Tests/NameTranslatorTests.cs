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
    class NameTranslatorTests
    {
        [Test]
        public void Test_TranslatesNames()
        {
            var unitundertest = new NameTranslator();
            var character = "Luke Skywalker";

            var result = unitundertest.Translate(character);

            Assert.That(result, Is.EqualTo("Bogdan"));
        }
    }
}
