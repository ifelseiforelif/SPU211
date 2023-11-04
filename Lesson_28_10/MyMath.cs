using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_28_10
{
    //Загальний сінтаксис створення типу делегату

    public delegate void MyDelegate(int n1, int n2); 
    /*
     * специфікаторДоступу delegate типПовертаємогоЗначення
    ім'яДелегату(списокПараметрів, якщо є);
    Делегати - referance types
    */
    public static class MyMath
    {
        public static void Sum(int n1, int n2)
        {
            Console.WriteLine("Sum: " + (n1 + n2));
        }
        public static void Mul(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
        public static void Substraction(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }

        public static void TestAction(int a, string b)
        {
            Console.WriteLine(b+a);
        }
    }
}
