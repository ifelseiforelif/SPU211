using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.GetStaticField());
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Student std = new Student(name);
            try
            {
                std.Age = 10;
                Console.WriteLine(std);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"На жаль {std.Name} не існує");
            }



            //string str = "Hello ";
            //for(int i=0;i<100;i++)
            //{
            //    str += (char)i;
            //}
            //Console.WriteLine(str);
            //StringBuilder sb = new StringBuilder("Hello ");
            //for (int i = 0; i < 100; i++)
            //{
            //    sb.Append((char)i);
            //}
            //Console.WriteLine(sb.ToString());
            //byte value = Convert.ToByte(Console.ReadLine());
            //try
            //{
            //    if (value == 0)
            //        throw new Exception("");
            //    byte result = checked((byte)(value * 2));
            //    Console.WriteLine(result);
            //}
            ////sealed
            //catch (Exception) when (value==200)
            //{
            //    Console.WriteLine("MyError");
            //}
            //catch (OverflowException ex) when (value>200)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception)
            //{

            //}


        }
    }
}
