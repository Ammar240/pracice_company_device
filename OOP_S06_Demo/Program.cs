using C_OOP06.ExtentionMethods;
using C_OOP06.Partials;
using C_OOP06.Sealed;

namespace C_OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Object Copy
            //int age01 = 30;

            //int age02 = age01;// Copy Value 

            //age02 = 40;


            //Console.WriteLine($"age01: {age01} age02: {age02}");


            //Person P01 = new Person("Ahmed", 30, new Address("Cairo"), 2);

            //Person P02 = P01;//2 Ref => Same Object

            //P02.Name = "Mahmoud";


            //Console.WriteLine(P02.Name);
            //Console.WriteLine(P01.Name);



            #endregion

            #region Shallow Copy
            //Person original = new Person("Sara", 25, new Address("Giza"));

            //Person Shallow = (Person)original.Clone();

            //Shallow.Name = "Ali";

            //Console.WriteLine(original.Name);

            //Console.WriteLine(Shallow.Name);
            //Console.WriteLine("===============================");
            //Shallow.Age = 50;
            //Console.WriteLine(original.Age);

            //Console.WriteLine(Shallow.Age);

            //Console.WriteLine("===============================");
            //Shallow.HomeAddress.City = "Alex";
            //Console.WriteLine(original.HomeAddress.City);
            //Console.WriteLine(Shallow.HomeAddress.City);


            #endregion

            #region Deep Copy
            //Person original = new Person();
            //original.Name = "Ahmed";
            //original.Age = 25;
            //original.HomeAddress = new Address("Cairo");
            //original.Phones = new string[] { "0122555", "0112555" };
            ////Person deep = (Person)original.Clone();

            //// Person deep = new Person(original);

            //Person deep = PersonCloner.DeepCopyBySerialization(original);
            //deep.Name = "Ali";

            //Console.WriteLine(original.Name);

            //Console.WriteLine(deep.Name);
            //Console.WriteLine("===============================");
            //deep.Age = 50;
            //Console.WriteLine(original.Age);

            //Console.WriteLine(deep.Age);

            //Console.WriteLine("===============================");
            //deep.HomeAddress.City = "Alex";
            //Console.WriteLine(original.HomeAddress.City);
            //Console.WriteLine(deep.HomeAddress.City);

            #endregion

            #region Static 
            #region Field -- Shared Status Between Objects
            //Console.WriteLine(Person.personCount);
            //Person P01 = new Person("Ahmed", 25, new Address("Cairo"));
            //Console.WriteLine(Person.personCount);
            //Person P02 = new Person("ALi", 25, new Address("Cairo"));
            //Console.WriteLine(Person.personCount);


            #endregion
            #region Method -- Utility (Helper Method)
            //Person guest = Person.CreateGuest();


            //Console.WriteLine(guest.Name);
            //Console.WriteLine(guest.Age);
            //Console.WriteLine(guest.HomeAddress.City);


            #endregion

            #region Constructor -- Initialize Static Members
            //  Person guest = Person.CreateGuest();


            #endregion

            #region Static Class -- Helper Class (No need to Any Object)

            #endregion
            #endregion

            #region Sealed
            //Parent parent = new Parent();

            //Console.WriteLine(parent.X);

            //parent.Display();

            //Child child = new Child();

            //Console.WriteLine(child.X);
            //child.Display();



            //GrandChild grand = new GrandChild();

            //Console.WriteLine(grand.X);
            //grand.Display();
            #endregion

            #region Extention Methods
            //int x = 12345;


            //Console.WriteLine(IntExtentions.Reverse(x));

            //Console.WriteLine(x.Reverse());


            //Person person = new Person("Ahmed", 25, new Address("Cairo"));



            //Console.WriteLine(person.IsAdult());

            //person.CanClone();

            //Child child = new Child();


            //child.IsAdult();

            //child.CanClone();
            #endregion

            #region Report
            //Person person = new Person("Ahmed",25,new Address("Cairo"));


            //Report report = new Report(person);

            //report.Generate();

            //report.AddDetail(".Net Developer");

            //report.OnGenerated();

            #endregion
        }
    }
}
