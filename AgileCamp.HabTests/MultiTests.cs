using System.Text.RegularExpressions;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class MultiTests
    {
        [Test, Ignore("fail")]
        public void Test5()
        {
            var s = "44 dd";
            Match match = Regex.Match(s, @"\d+");


            Assert.AreEqual(match.Value, 48);
            var i = int.Parse(match.Value);

            Assert.AreEqual(i, 48);
        }
    }
}