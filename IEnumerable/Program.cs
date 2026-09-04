namespace IEnumerableProject;

internal partial class Program
{
    static void Main(string[] args)
    {
        #region Equals override
        /*Employee e1 = new Employee
        {
            Id = 1,
            Name = "Ammar",
            Salary = 10000m,
            Department = "IT"
        };
        Employee e2 = new Employee
        {
            Id = 1,
            Name = "Ammar",
            Salary = 10000m,
            Department = "IT"
        };
        //before override Equals(); and == operator -> compare references not content
        //Console.WriteLine(e1 == e2); // false 
        //Console.WriteLine(e1.Equals(e2));// false

        //After override Equals(); and == operator -> compare content
        Console.WriteLine(e1 == e2); // true 
        Console.WriteLine(e1.Equals(e2));// true

        //HashCode
        Console.WriteLine(e1.GetHashCode());
        Console.WriteLine(e2.GetHashCode());*/
        #endregion

        #region IEnumerable & IEnumerator
        //var ints = new FiveIntergers(1, 2, 3, 4, 5);
        //foreach (var item in ints)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion

        #region IComparable
        //List<Temperature> temps = new List<Temperature>();
        //Random rnd = new Random();
        //for (int i = 0; i < 10; i++)
        //{
        //    temps.Add(new Temperature(rnd.Next(-30, 50)));
        //}

        //temps.Sort();


        //foreach (var item in temps)
        //{
        //    Console.WriteLine(item.Value);
        //} 
        #endregion

    }
}
