using System;
using AgileCamp.Habitator.Models;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class CreateHabitTests
    {
        [Test]
        public void СозданиеПривычкаБезНазвания_ВызываетИсключение()
        {
            Assert.Throws<ArgumentNullException>(() => new Habit(null));
        }
    }
}