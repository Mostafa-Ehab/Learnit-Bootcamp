using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Duration
    {
        private int _hours;
        public int Hours {
            get { return _hours;  }
            set {
                if (value < 0) 
                    throw new ArgumentOutOfRangeException("value");
                _hours = value;
            }
        }

        private int _minutes;
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || value >= 60)
                    throw new ArgumentOutOfRangeException("value");
                _minutes = value;
            }
        }

        private int _seconds;
        private int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 || value >= 60)
                    throw new ArgumentOutOfRangeException("value");
                _seconds = value;
            }
        }

        private int minutes { get; set; }
        private int seconds { get; set; }
        public Duration(int hours, int minutes, int seconds) {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds = seconds % 3600;

            Minutes = seconds / 60;
            seconds = seconds % 60;

            Seconds = seconds;
        }

        public string getStirng()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
    }
}
