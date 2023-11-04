using System;
using Lesson16_09;

namespace Lesson09_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog dog = new Dog("Grey",5);
            dog.ShowDog();
            Console.ReadLine();
        }
    }
}
