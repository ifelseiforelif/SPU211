using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

/*
 * Тема: Generics
 * Бувають 2 видів: узагальненні та неузагальненні
 *  Неузагальнені колекції.
 *  Так як всі типи є спадкоємцями типу object, можна створити масив з
 *  об'єктів різних типів.
 *  Але коли об'єкт ValueType потрапляє у такий масив або просто
 *  створюємо змінну ось так
 *   object n = 10; то відбувається процес упакування (boxing), який
 *   є дуже важкий та негативно впливає на продуктивність програми
 *   Процес, коли ValueType, який був упакований у купу повертається назад,
 *   це називається процесом распакування (unboxing)
 *      int n2 = (int)n; //unboxing
 *      На практиці краще неузагальненні колекції не використовувати
 */
namespace Lesson21_10
{
    //public struct Cat { }
    //public class Dog 
    //{

    //}



    class BankAccount<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
    }


    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"Book. {Title} {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object n = 10; //boxing;
            //int n2 = (int)n; //unboxing

            //object[] arrObj = {5, 3.5, true, new Cat(), new Dog()}; //процесс boxing
            //int result = 10 * (int)arrObj[0]; //int*object  unboxing
            //Неузагальнена колекція
            //ArrayList list = new ArrayList();
            //list.Add(new Cat());
            //list.Add(4);
            //list.Add(5.6);
            //list.Add(new Dog());

            //Console.WriteLine(list[1]);

           // List<Book> books = new List<Book>();
           // books.Add(new Book() { Title="Book1", Author="Author1"});
           // books.Add(new Book() { Title="Book2", Author="Author2"});
           // books.Add(new Book() { Title="Book3", Author="Author3"});
           //foreach(Book book in books) 
           //{
           //     Console.WriteLine(book);
           // }
        }
    }
}
