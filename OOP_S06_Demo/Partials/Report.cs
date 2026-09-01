using C_OOP06.ExtentionMethods;
using C_OOP06.Sealed;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP06.Partials
{
    internal partial class Report
    {
        public Person Subject;

        public Report(Person subject)
        {
            Subject = subject;
        }

        public void Generate()
        {
            Console.WriteLine($"Report For {Subject.GetDisplayName()}");

            OnGenerated();
        }

        partial void OnGenerated();//Implement From Other Part

        public void Z()
        {
            throw new NotImplementedException();
        }
    }
}
