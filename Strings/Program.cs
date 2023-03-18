using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Alperen Sürmeli.";
            var result = sentence.Length;
            Console.WriteLine(result);

            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result3);
            Console.WriteLine(result4);
                
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.LastIndexOf(" ");
            Console.WriteLine(result5);
            Console.WriteLine(result6);

            var result7 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result7);

            var result8 = sentence.Substring(3);
            Console.WriteLine(result8);

            var result9 = sentence.ToLower();
            Console.WriteLine(result9);

            var result10 = sentence.ToUpper();
            Console.WriteLine(result10);

            var result11 = sentence.Replace(" ", "-");
            Console.WriteLine(result11);

            var result12 = sentence.Remove(2);
            Console.WriteLine(result12);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
