using System;
using AgileCamp.Habitator.Models;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class CreateHabitTests
    {
        private const string ValidName = "running";

        [Test]
        public void ���������������������������_������������������()
        {
            Assert.Throws<ArgumentNullException>(() => new Habit(null));
        }

        [Test]
        public void ����������������������������������_������������������()
        {
            Assert.Throws<ArgumentException>(() => new Habit("a"));
        }

        [Test]
        public void ����������������_�������()
        {
            Assert.DoesNotThrow(() => new Habit(ValidName));
        }

        [Test]
        public void ����������������_���������������()
        {
            var habit = new Habit(ValidName);
            Assert.AreEqual("��������:" + ValidName, habit.Name);
        }
    }
}