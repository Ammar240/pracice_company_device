using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP06.Partials
{
    internal partial class Report:IParent
    {
        public void AddDetail(string Detail)
        {
            Console.WriteLine($"Detail: {Detail}");
        }

        public void X()
        {
            throw new NotImplementedException();
        }

        public void Y()
        {
            throw new NotImplementedException();
        }

     

        partial void OnGenerated()
        {
            Console.WriteLine("Generate Complete..");
        }
    }
}
