using System;
using AgileCamp.Habitator.Models;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class CreateHabitTests
    {
        [Test]
        public void ���������������������������_������������������()
        {
            Assert.Throws<ArgumentNullException>(() => new Habit(null));
        }
    }
}