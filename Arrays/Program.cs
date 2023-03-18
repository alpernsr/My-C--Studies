using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Alperen";
            students[1] = "Simge";
            students[2] = "Sahra";
            foreach (string student in students) { 
                Console.WriteLine(student);
                Console.WriteLine("**********");

            }
            string[,] regions = new string[7, 3]
            {
                {"İstanbul", "İzmit", "Edirne" },
                {"Ankara", "Çankırı", "Çorum" },
                {"Kars", "Erzurum", "Malatya" },
                {"Trabzon", "Samsun", "Artvin" },
                {"Çanakkale", "İzmir", "Muğla" },
                {"Antalya", "Mersin", "Adana" },
                {"Gaziantep", "Adıyaman", "Hatay" }
        };
            for (int i = 0;i <= regions.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**********");
            }
            Console.ReadLine();
        }
    }
}
