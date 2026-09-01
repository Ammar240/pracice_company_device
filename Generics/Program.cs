//using Generics.order;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Generics;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        #region swap any type
//        //int x = 10, y = 20;
//        //Swaping.Swap(ref x, ref y);
//        //Console.WriteLine($"x = {x} , y = {y}");

//        //double a = 10.5, b = 3.556;
//        //Swaping.Swap(ref a, ref b);
//        //Console.WriteLine($"a = {a} , b = {b}");

//        //string s01 = "string 01", s02 = "string 02";
//        //Swaping.Swap(ref s01, ref s02);
//        //Console.WriteLine($"s01 = {s01} , s02 = {s02}"); 
//        #endregion

//        Repository<Customer> customerRepo = new Repository<Customer>();
//        Repository<Product> productRepo = new Repository<Product>();
//        Repository<Order> orderRepo = new Repository<Order>();

//        customerRepo.Add(new Customer() { Id = 1, Name = "Ammar" });
//        productRepo.Add(new Product() { Id = 1, Name = "phone", Price = 15000m });
//        orderRepo.Add(new Order() { Id = 1, TotalPrice = 20000m });

//        //customerRepo.Add(new Order()); //XX not (type safty)
//        customerRepo.PrintValue("Hellow from customer repo");
//        Console.WriteLine(customerRepo.GetById(1));
//        customerRepo.GetAll();

//        string la = customerRepo.GetValue("lablabal");
//        Console.WriteLine(la);

//    }
//}
