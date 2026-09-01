using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP06
{
    internal class Person:ICloneable
    {
        public static int personCount;
        public static string defultAddress;
        public string Name { get; set; }

        public int Age { get; set; }

        public Address HomeAddress { get; set; }

        public string[] Phones { get; set; }

        public Person()
        {

        }
        public Person(string name, int age, Address address)
        {
            Name = name;
            Age = age;
            HomeAddress = address;
            personCount++;
        }

        public static Person CreateGuest()
        {
            return new Person("Guest", 0, new Address(defultAddress));
        }

        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            HomeAddress = new Address(other.HomeAddress.City);
            Phones = (string[])other.Phones.Clone();

        }

        static Person()
        {
            defultAddress = "Cairo";

        }


        private Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public object Clone()
        {
            return DeepCopy();
        }

        private Person DeepCopy()
        {
            Person copy = (Person)MemberwiseClone();
            copy.HomeAddress = new Address(HomeAddress.City);
            copy.Phones = (string[])Phones.Clone();
            return copy;
        }

       
    }
}
