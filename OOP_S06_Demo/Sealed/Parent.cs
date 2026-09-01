using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP06.Sealed
{
    internal  class Parent
    {
        public virtual int X { get; set; }

        public virtual void Display()
        {
            Console.WriteLine("This is Parent Class");
        }
    }

    class Child:Parent
    {
        public sealed override int X { get => base.X; set => base.X = value; }

        public sealed override void Display()
        {
            Console.WriteLine("This is Child Class");
        }
    }
    class GrandChild:Child
    {
        //public override int X { get => base.X; set => base.X = value; }

        //public override void Display()
        //{
        //    base.Display();
        //}
    }
}
