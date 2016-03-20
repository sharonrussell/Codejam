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
            var character = "Luke";

            var result = unitundertest.Translate(character);

            Assert.That(result, Is.EqualTo("Bogdan"));
        }

        [Test]
        public void Test_OnlyTranslatesCharacterNames()
        {
            var unitundertest = new NameTranslator();
            var openingText = "Once upon a time, Luke Skywalker went to the shops...";

            var result = unitundertest.Translate(openingText);

            Assert.That(result, Is.EqualTo("Once upon a time, Bogdan Skywalker went to the shops..."));
        }

        [Test]
        public void TestWithRealData()
        {
            var unitundertest = new NameTranslator();
            var openingText = "Princess\n\nLeia races home aboard her\n\nstarship";

            var result = unitundertest.Translate(openingText);

            Assert.That(result, Is.EqualTo("Princess\n\nMaiya races home aboard her\n\nstarship"));
        }
    }
}
