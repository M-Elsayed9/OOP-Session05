using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Project01
{
    public class _3DPoint : IComparable, ICloneable
    {
        #region Properties
        public int X { get; set; }  
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region Constructors
        public _3DPoint() : this(0, 0, 0)
        {
        }

        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public void ReadPoint()
        {
            Console.WriteLine($"Enter Cordinates of the Point:");
            Console.Write("Enter X:");
            X = int.Parse(Console.ReadLine());

            Console.Write("Enter Y:");
            Y = Convert.ToInt32(Console.ReadLine());

            int z;

            do
            {
                Console.Write("Enter Z:");
            } while (!int.TryParse(Console.ReadLine(), out z));
            Z = z;
        }

        public int CompareTo(object? obj)
        {
            if (obj is null)
            {
                return 1;
            }

            _3DPoint other = (_3DPoint)obj;

            if (this.X != other.X)
            {
                return this.X.CompareTo(other.X);
            }
            else if (this.Y != other.Y)
            {
                return this.Y.CompareTo(other.Y);
            }
            else
            {
                return 0;
            }
        }

        public object Clone()
        {
            return new _3DPoint(X, Y, Z);
        }

        public static bool operator ==(_3DPoint a, _3DPoint b)
        {
            return (a.X.Equals(b.X)) &&
                (a.Y.Equals(b.Y)) && (a.Z.Equals(b.Z));
        }

        public static bool operator !=(_3DPoint a, _3DPoint b)
        {
            return !(a == b);
        }

        #endregion
    }
}