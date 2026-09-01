//namespace ListsAndDictionaries;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Country egypt = new Country { Name = "Egypt", CountryCode = "EGY" };
//        Country iraq = new Country { Name = "Iraq", CountryCode = "IRQ" };
//        Country jordan = new Country { Name = "Jordan", CountryCode = "Jor" };
//        Country emerates = new Country { Name = "Emerates", CountryCode = "AUE" };
//        Country america = new Country { Name = "America", CountryCode = "USA" };


//        Country[] countriesArray = {
//            egypt, iraq, jordan, emerates, america
//        };

//        List<Country> countryList = new List<Country>(3);// 3 initial capacity

//        // Add , AddRange methods , Count , Capacity Attributes
//        Console.WriteLine($"Capacity: {countryList.Capacity}, Count: {countryList.Count}");
//        countryList.Add(new Country {Name="Moroco",CountryCode="MAR" });
//        Console.WriteLine($"Capacity: {countryList.Capacity}, Count: {countryList.Count}");

//        countryList.AddRange(countriesArray);
//        Console.WriteLine($"Capacity: {countryList.Capacity}, Count: {countryList.Count}");// capacity doubled

//        // Insert , Insertrange -> adds an element at a spicific index

//        countryList.Insert(1, new Country { Name = "Brasel", CountryCode = "BRA" });
//        countryList.Insert(0, new Country { Name = "France", CountryCode = "FRA" });
//        countryList.Add(new Country { Name = "Aljeria", CountryCode = "ALJ" });


//        // index access 
//        Console.WriteLine($"1st Country: {countryList[0]}");
//        Console.WriteLine($"Last Country: {countryList[countryList.Count-1]}");

//        //print list
//        Console.WriteLine("===== Counntry List =====");
//        foreach(var  country in countryList)
//        {
//            Console.WriteLine(country);
//        }

//        // RemoveAt() -> remove at index , Rmover() -> remove by value
//        Console.WriteLine("===== After rmove =====");
//        countryList.RemoveAt(3);

//        //countryList.Remove(new Country { Name = "Brasel", CountryCode = "BRA" });
//        // should override equals()
//        countryList.RemoveAll(x => x.Name == "Brasel");
//        countryList.Remove(new Country { Name = "emerates", CountryCode = "AuE" });

//        Console.WriteLine("===== Counntry List =====");
//        foreach (var country in countryList)
//        {
//            Console.WriteLine(country);
//        }
//    }
//}
