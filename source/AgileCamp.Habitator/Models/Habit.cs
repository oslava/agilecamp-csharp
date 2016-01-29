using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgileCamp.Habitator.Models
{
    public class Habit
    {
        public int HabitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Time { get; set; }

        public Habit()
        {
            
        }

        public Habit(string name)
        {
            throw new ArgumentNullException();
        }
    }
}