using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{
    public class Course : IValuable
    {

        private static double courseHourValue = 875;

        public static double CourseHourValue
        {
            get { return courseHourValue; }
            set { courseHourValue = value; }
        }

        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int durationInMinutes;

		public int DurationInMinutes
		{
			get { return durationInMinutes; }
			set { durationInMinutes = value; }
		}

		public Course( string Name, int durationInMinutes)
		{
			this.durationInMinutes = durationInMinutes;
			this.Name = Name;
		}

		public Course(string Name) :
			this(Name, 0)
		{ 
			this.Name = name; 
		}
        public double GetValue()
        {
            double pris = (int)((DurationInMinutes + 59) / 60) * CourseHourValue;

            return pris;

        }

        public override string ToString()
		{
            //"Name: Magi – når videnskaben stopper, Duration in Minutes: 157"
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
		}

	}
}
