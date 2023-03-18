using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2]
            {
                new Customer{Name = "Alperen" }, new Student{Name = "Simge"}
            };
            foreach (var person in persons) 
            {
            Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }
    }class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }class Customer:Person
    {
        public int City { get; set; }
    }class Student:Person
    {
        public int Departmant { get; set; }
    }
}
