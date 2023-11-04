using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_10
{
    class MyArray
    {
        public int[] Arr { get; set; }
        public int Size { get; set;}
        public MyArray(int s)
        {
            if (s <= 0)
                throw new ArgumentNullException();
            Size = s;
            Arr = new int[Size];
            Random r = new Random();
            for(int i=0;i<Size;i++)
            {
                Arr[i] = r.Next(-10, 10);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var el in Arr)
            {
                sb.Append(el.ToString());
                sb.Append(' ');
            }
            return sb.ToString();
        }
        
        /*
         * Індексатори - це окрема конструкція у мові C#, яка дозволяє
         * до об'єкту нашого типу застосовувати оператор []
         * Це потрібно, коли полем класу є масив і ми бажаємо звертатись
         * до елементів цього масиву у знайомий для нас спосіб, тобто за
         * індексом
        */

        public int this[int index]
        { 
            get {
                if(index<0 || index>=Arr.Length)
                    throw new IndexOutOfRangeException();
                return Arr[index]; 
            } 
            set
            {
                if (index < 0 || index >= Arr.Length)
                    throw new IndexOutOfRangeException();
                Arr[index] = value;
            }
        }
    }

    class Number
    {
        public int N { get; set; }
        public Number(int n)
        {
            N = n;
        }
        public override string ToString()
        {
            return $"Number: {N}";
        }
        public static Number operator+(Number obj, int n)
        {
            return new Number(obj.N + n);
        }
        public static Number operator +(int n, Number obj)
        {
            return obj+n;
        }
       
        public static bool operator>(Number n1, Number n2)
        {
            return n1.N > n2.N;
        }
        public static bool operator <(Number n1, Number n2)
        {
            return n1.N < n2.N;
        }
    }

internal class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(10);
            Console.WriteLine(arr);
            arr[0] = 10000;
            Console.WriteLine(arr);
            //Number n1 = new Number(100);
            //Number n2 = 30+n1;
            //if(n1>n2)
            //{
            //    Console.WriteLine(n1);
            //}
            //else
            //{
            //    Console.WriteLine(n2);
            //}

        }
    }
}
