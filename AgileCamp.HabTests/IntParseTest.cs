using System.Text.RegularExpressions;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class IntParseTests
    {
        private readonly MultiTests multiTests = new MultiTests();

        [Test]
        public void ParseTest()
        {
            var result = int.Parse("78");

            Assert.AreEqual(result, 78);
        }

        [Test]
        public void TryParseTest()
        {
            int x;
            var result = int.TryParse("78", out x);

            Assert.True(result);
            Assert.AreEqual(x, 78);
        }

        [Test]
        public void TryParse2Test()
        {
            int x;
            var result = int.TryParse("78.9", out x);

            Assert.False(result);
            Assert.AreEqual(x, 0);
        }

        [Test]
        public void RegExTest()
        {
            Match match = Regex.Match("3456  sss", @"\s+");

            Assert.AreEqual(match.Value, "  ");
        }
    }
}