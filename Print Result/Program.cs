using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.MyInteger = 3;
            Console.WriteLine(animal.MyInteger);

            Dog dog = new Dog();
            dog.MyInteger = 5;
            Console.WriteLine(dog.MyInteger);

            Cat cat = new Cat();
            cat.MyInteger = 6;
            Console.WriteLine(cat.MyInteger);

            Mouse mouse = new Mouse();
            mouse.MyInteger = 9;
            Console.WriteLine(mouse.MyInteger);





            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //Console.WriteLine("Hello there!");
            //Console.ReadLine();

        }
    }
}
