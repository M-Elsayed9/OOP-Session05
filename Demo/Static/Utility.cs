using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    // static class : container for static memers [property, method, Attribute, Constructor] & Constants
    // cannot create Object member [method, attributes or constructors]
    // you canot create an object from static class
    // can not be inherited from static class 
    internal static class Utility
    {
        // Object Member Property
        //public int X { get; set; }
        //public int Y { get; set; }

        // class member attribute - static attribute
        //compiler will initialize static attribute with default value
        //private static double pi = 3.14; // 3.14 with static constructor

        // Constant 
        private const double pi = 3.14;

        // class member property - static attribute
        // Must be Get or Set or both
        // 1. Static Attribute
        // 2. Constant Value
        public static double Pi
        {
            get { return pi; }
        }

        // Class Member Constructor -- static constructor[ max 1 per class]
        // cant specify access modifiers or parameters for static constructors 
        // will be eexecuted one time per class lifetime by CLR and
        // before its first usage
        // 1. call [static method or static property
        // 2. create Object from this class
        // 3. Create object from another class inheriting from this class
        static Utility()
        {
            // Used to initilize staic attributes
            //pi = 3.14; // invalid if its a constant
        }

        //Object Member Constructor
        // non static 
        // is not the right place to initilize static attribute
        //public Utility(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //    //pi = 3.14;
        //}

        // Class Member Method - static method
        public static double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }

        // Class member method - static method
        public static double CalcCircleArea(double radius)
        {
            // Pi is an object member property | attribute
            // cannot use it in a static method

            //Utility utility = new Utility(10, 5);

            return pi * Math.Pow(radius, 2);
        }

      
        // Object Member Method
        //public override string ToString()
        //{
        //    return $"X : {X} Y : {Y}";
        //}
    }
}
