using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 GC - Garbage Collector
В .NET реалізоване автоматичне прибирання сміття.
Керуєма купа (віртуальний адресний простір, який виділяється
системою під нашу програму) розбита на 3 покоління: 0,1,2
За таким принципом: 0 - найменьше, а наступні більше одна за одну(за зростанням)
Перший раз GC запускається, коли нульове покоління повністю заповнено 
та з'являється новий об'єкт. Програма при цьому далі не виконується (пауза)
GC при цьому переглядає нульове покоління, досяжні об'єкти (об'єкти, які ще використо
вуються програмою, є активні посилання на них) маркіруються, потім перносяться у нове
покоління, при умові, що там є вільне місце. Не досяжні об'єкти видаляються з купи.
Об'єкти, які досяжні проходять 3 етапи при переносі до іншого покоління:
1) маркування
2) сжатіє
3) перенос у наступне покоління
Якщо у наступному поколінні немає місця, то GC починає перевіряти його і працює так само
Тезіси о GC:
1) нові об'єкти живуть мало
2) старі об'єкти живуть довго
3) перевірка меншої ділянки пам'яті відбувається скоріше 
за перевірку більш об'ємної ділянки пам'яті
 */

namespace Lesson14_10
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Розмір пам'яті у байтах в heap: {0}", GC.GetTotalMemory(false));
            Point p = new Point() { X = 10, Y = 90 };
            Console.WriteLine("Розмір пам'яті у байтах в heap: {0}", GC.GetTotalMemory(false));
            Console.WriteLine("Наш обєкт у поколінні {0}", GC.GetGeneration(p));
            const int N = 10000000;
            Point[] listP = new Point[N];
            for (int i = 0; i < listP.Length; i++)
            {
                listP[i] = new Point() { X = 1, Y = 2 };
                //Console.WriteLine("Розмір пам'яті у байтах в heap: {0}", GC.GetTotalMemory(false));
            }
            Console.WriteLine("Наш обєкт у поколінні {0}", GC.GetGeneration(p));
            //GC.Collect();
            //Console.WriteLine("Наш обєкт у поколінні {0}", GC.GetGeneration(p));
            //GC.Collect();
            //Console.WriteLine("Наш обєкт у поколінні {0}", GC.GetGeneration(p));
            Console.WriteLine("Розмір пам'яті у байтах в heap: {0}", GC.GetTotalMemory(false));
            Console.WriteLine(GC.CollectionCount(2));
            Console.WriteLine(GC.MaxGeneration);
        }
    }
}
