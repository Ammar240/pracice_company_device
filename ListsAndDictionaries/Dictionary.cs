//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ListsAndDictionaries;

//internal class Dictionary
//{
//    static void Main(string[] args)
//    {
//        var article =
//            "Dot NET is a free cross-platform and open source developer platform" +
//            "for building many different types of applications" +
//            "With Dot NET you can use multiple languages and libraries" +
//            "to build for web and IoT";

//        Dictionary<char, List<string>> letterDictionary = new Dictionary<char, List<string>>();

//        foreach (var word in article.Split())
//        {
//            foreach (var ch in word)
//            {
//                char c = char.ToLower(ch);
//                if (letterDictionary.ContainsKey(c))
//                {
//                    letterDictionary[c].Add(word.ToLower());
//                }
//                else
//                {
//                    letterDictionary.Add(c, new List<string> { word.ToLower() });
//                }
//            }
//        }
//        foreach (var entry in letterDictionary)
//        {
//            Console.WriteLine($"{entry.Key}");
//            foreach (var word in entry.Value)
//            {
//                Console.WriteLine($"\t\t{ word}");
//            }
//        }
//    }
//}

