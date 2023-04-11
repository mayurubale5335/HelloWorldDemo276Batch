using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo276Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 276 Batch");
            Console.WriteLine("Code pushing from 2nd Developer");
            Console.WriteLine("Modified in Local Repository");
            Console.WriteLine("Modified from Remote Repository");
            // object or instance syntax
            // ClassName variable = new ClassName();
            Human human = new Human();
            Console.WriteLine("please enter human name");
            human.name = Console.ReadLine();
            Console.WriteLine("please enter human height");
            human.height =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter human weight");
            human.weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter human age");
            human.age = Convert.ToInt32(Console.ReadLine());
            human.talk();
            human.HumanDetails(human.name, human.height, human.weight, human.age);
            Console.ReadLine();

        }
    }
}
