using Demo.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract Class : Partial implmentation for other classes [Not full Implmented]
    // Abstract Class : Can't be instantiated
    // Abstract Class : Can have abstract methods
    // Abstract Class : Can have non-abstract methods
    // Abstract Class : Can have abstract properties
    // Abstract Class : Can have non-abstract properties
    // Abstract Class : Can have abstract events
    // Abstract Class : Can have non-abstract events
    // Abstract Class : Can have abstract indexers
    // Abstract Class : Can have non-abstract indexers
    // Abstract Class : Can have abstract operators
    // Abstract Class : Can have non-abstract operators
    // Abstract Class : Can have abstract constructors
    // Abstract Class : Can have non-abstract constructors
    // Abstract Class : Can have abstract destructors
    // Abstract Class : Can have non-abstract destructors
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal Perimter { get; }

        public Shape(decimal Dim01, decimal Dim02)
        {
            Dim01 = Dim02 = 0;
        }

        // Object Member abstract Method
        public abstract decimal Area();
        // Not Implmented Method
        // Abstract Method Must Be contained in Abstract Class
    }


    abstract class RectBase : Shape
    {
        public RectBase(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }

        public override decimal Area()
        {
            throw new NotImplementedException();
        }
    }

    // Class : Interface => Implment 
    // Class : class => Inherit
    // Abstract Class : Class => implment & Inherit

    class Rectangle : RectBase
    {
        public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }


        public override decimal Perimter => (Dim01 + Dim02) * 2;

        public override decimal Area()
        {
            return Dim01 * Dim02;
        }
    }

    class Square : RectBase // implement and inherit 
    {
        public Square(decimal dim01) : base(dim01, dim01)
        {
        }

        //public Square(decimal dim)
        //{
        //    Dim01 = Dim02 = dim;
        //}

        public override decimal Area() => Dim01 * Dim01;

        public override decimal Perimter => Dim01 * 4;
    }

    class Circle : Shape
    {

        public Circle(decimal radius) : base(radius, radius)
        {
        }
        //public Circle(decimal radius)
        //{
        //    Dim01 = Dim02 = radius;
        //}
       public override decimal Perimter => 2 * (decimal)Math.PI * Dim01;

       public override decimal Area() => (decimal)Math.PI * (Dim01 * Dim01);
    }
}