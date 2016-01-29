using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class FirstTests
    {
        [Test]
        public void SuccessTest()
        {
            Assert.AreEqual(1,1);
        }

        [Test]
        public void FailTest()
        {
            Assert.IsTrue(false);
        }
        [Test]
        public void SuccessTest1()
        {
            Assert.AreNotEqual(1,2);
        }
        [Test]
        public void SuccessTest2()
        {
            Assert.IsFalse(false);
        }

    }
}
