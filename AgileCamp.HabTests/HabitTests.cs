using System;
using AgileCamp.Habitator.Models;
using NUnit.Framework;

namespace AgileCamp.HabTests
{
    public class CreateHabitTests
    {
        private const string ValidName = "running";

        [Test]
        public void СозданиеПривычкаБезНазвания_ВызываетИсключение()
        {
            Assert.Throws<ArgumentNullException>(() => new Habit(null));
        }

        [Test]
        public void СозданиеПривычкиСКороткимНазванием_ВызываетИсключение()
        {
            Assert.Throws<ArgumentException>(() => new Habit("a"));
        }

        [Test]
        public void СозданиеПривычки_Успешно()
        {
            Assert.DoesNotThrow(() => new Habit(ValidName));
        }

        [Test]
        public void СозданиеПривычки_ПрефиксНазвания()
        {
            var habit = new Habit(ValidName);
            Assert.AreEqual("Привычка:" + ValidName, habit.Name);
        }
    }
}