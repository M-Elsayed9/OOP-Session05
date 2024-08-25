using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class Parent
    {

        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("I am parent");
        }

    }

    class Child : Parent
    {

        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 5000 ? 5000 : value; }
        }
        // Sealed Mehtod 
        // sealed override => Prevent Override from Inherited classes
        // can be inherited but not overridden
        // new => End old sequence 
        public sealed override void Print()
        {
            Console.WriteLine("I am Child ");
        }
    }

    sealed class GrandChild : Child
    {

        //public override int Salary
        //{
        //    get { return base.Salary; }
        //    set { base.Salary = value < 10000 ? 10000 : value; }
        //}

        //public override void Print() // invalid  -> print Inherited
        //{
        //    Console.WriteLine("Iam Grandchild");
        //}
    }
}
