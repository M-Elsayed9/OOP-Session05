using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Porject03
{
    public class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructors

        public Duration(int hours, int minutes, int seconds)
        {
            Seconds = seconds % 60;
            minutes += (seconds / 60);
            Minutes = minutes % 60;
            hours += (minutes / 60);
            Hours = hours;
        }

        public Duration(int time)
        {
            Hours = time / 3600;

            time %= 3600; // time -= Hours * 3600

            Minutes = time / 60;

            Seconds = time % 60;
        }

        // 3600 + 3600 = 7200
        // 600 /60 = 10

        // 666 = 0
        // 666 /60 = 11
        // 6 
        #endregion

        #region Methods
        public override string ToString()
        {
            if (Hours == 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration duration = (Duration)obj;

            return Hours == duration.Hours &&
                   Minutes == duration.Minutes &&
                   Seconds == duration.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        public static Duration operator +(Duration d1, int time)
        {
            return new Duration(time + (d1.Hours * 3600) + (d1.Minutes * 60) + d1.Seconds);
        }

        public static Duration operator +(int time, Duration d1)
        {
            return new Duration(time + (d1.Hours * 3600) + (d1.Minutes * 60) + d1.Seconds);
        }

        public static Duration operator ++(Duration d)
        {
            d.Minutes++;
            return d;
        }

        public static Duration operator --(Duration d)
        {
            d.Minutes--;
            return d;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            // 0 50 0
            // 1 -10 0
            return new Duration(((d1.Hours * 3600) + (d1.Minutes * 60) + d1.Seconds) - ((d2.Hours * 3600) + (d2.Minutes * 60) + d2.Seconds));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1.Hours > d2.Hours) return true;
            else if (d1.Hours < d2.Hours) return false;
            else if (d1.Minutes > d2.Minutes) return true;
            else if (d1.Minutes < d2.Minutes) return false;
            else if (d1.Seconds > d2.Seconds) return true;
            else return false;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours) return true;
            else if (d1.Hours > d2.Hours) return false;
            else if (d1.Minutes < d2.Minutes) return true;
            else if (d1.Minutes > d2.Minutes) return false;
            else if (d1.Seconds < d2.Seconds) return true;
            else return false;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1.Hours > d2.Hours) return true;
            else if (d1.Hours < d2.Hours) return false;
            else if (d1.Minutes > d2.Minutes) return true;
            else if (d1.Minutes < d2.Minutes) return false;
            else if (d1.Seconds > d2.Seconds) return true;
            else if (d1.Seconds < d2.Seconds) return false;
            else return true;

        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours) return true;
            else if (d1.Hours > d2.Hours) return false;
            else if (d1.Minutes < d2.Minutes) return true;
            else if (d1.Minutes > d2.Minutes) return false;
            else if (d1.Seconds < d2.Seconds) return true;
            else if (d1.Seconds > d2.Seconds) return false;
            else return true;
        }

        public static bool operator true(Duration d)
        {
            return (d.Hours > 0) || (d.Minutes > 0) || (d.Seconds > 0);
        }

        public static bool operator false(Duration d)
        {
            return (d.Hours == 0) && (d.Minutes == 0) && (d.Seconds == 0);
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(2024, 7, 28, d.Hours, d.Minutes, d.Seconds);
        }

        #endregion
    }
}
