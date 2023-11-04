using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_09
{
    internal class Program
    {
        static void Up(ref int n)
        {
            n++;
        }

        static void Change(ref int[] arr)
        {
            arr = null;
            arr = new int[5] { 33, 44, 55, 66, 77 };
        }
        static void TestOut(out int temp)
        {
            temp = 100;
        }
        static void Main(string[] args)
        {
            int y;
            TestOut(out y);
            Console.WriteLine(y);

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Change(ref arr);
            foreach(int i in arr) 
            {
                Console.Write(i+" ");
            }
            //int n = 100;
            //Up(ref n);
            //Console.WriteLine(n);




            //Перетворення типів
            //int d = (int)100.5;

            //Dog d1 = new Dog("Eric",5);
            //d1 = null;
            //d1?.ShowDog();


            //int[] arr = new int[5] { 1, 2, 4, 5, 6 };
            //int[] arr = new int[5];
            //Random random = new Random();
            //for(int i=0; i<arr.Length; i++)
            //{
            //    arr[i] = random.Next(-10,100);
            //    Console.Write(arr[i] + " ");
            //}
            //Console.Write(Environment.NewLine);
            //Array.Sort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Array.Reverse(arr);
            //Console.Write(Environment.NewLine);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " "); 
            //}

            //Console.WriteLine();
            //foreach(int el in arr)
            //{
            //    Console.Write(el+" ");
            //}
            //Console.WriteLine();
            //int[,] arr2D = new int[2, 3] { {1,2,3 },{4,5,6 } };
            //for(int i=0;i<arr2D.GetLength(0);i++)
            //{
            //    for(int j=0;j<arr2D.GetLength(1);j++)
            //    {
            //        Console.Write(arr2D[i,j]+" ");
            //    }
            //    Console.Write("\n");
            //}

            //string name = "Bogdan";
            //int age = 23;
            //float average = 10.8f;
            //Console.WriteLine("Name: "+ name + " Age: " + age); //конкатенація
            //Console.WriteLine("Name: {0} Age: {1} Average {2}", name,age,average);
            //Console.WriteLine($"Name {name} Age {age} Average {average}"); //інтерполяція

            //Console.WriteLine("Enter Age: ");
            ////int n = int.Parse(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());

            //Dog dog = new Dog("Eric", n);
            //dog.ShowDog();
            //Cat cat = new Cat();
            //cat.ShowCat();
            Console.ReadLine();
        }
    }
}
