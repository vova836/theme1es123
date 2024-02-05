using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            Person person1 = new Person();
            Console.WriteLine($"{person1.GetInfo()}");
            Person person2 = new Person(18, "Владимир");
            Console.WriteLine($"{person2.GetInfo()}");
            Person person3 = new Person(18, "Владимир", "Янишевский");
            Console.WriteLine($"{person3.GetInfo()}");
            Employee person4 = new Employee();
            Console.WriteLine($"{person4.Info()}");
            Employee person5 = new Employee("Dex");
            Console.WriteLine($"{person5.Info()}");
            Employee person6 = new Employee("Dex", "Программист");
            Console.WriteLine($"{person6.Info()}");
            Console.ReadKey();
        }
    }
}
