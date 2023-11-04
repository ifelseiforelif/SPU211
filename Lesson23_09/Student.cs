using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23_09
{
    internal class Student
    {
        private readonly string _inn;
        private static string AddressUnivercity;
        private const string _titleUnivercity = "ITSTEP";

        static Student()
        {
            Console.WriteLine("I am static construct");
            AddressUnivercity = "Sadovaya 3";
        }
    
        public static string GetStaticField()
        {
            return AddressUnivercity;
        }
        public Student(string n)
        {
            _inn = "322243443";
            Name = n;
        }


        public string INN
        { get { return _inn; } }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                    throw new InvalidOperationException("Вік не може бути з -");
                _age = value;
            }
        }
        public string Name { get; set; } //Властивість

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age}";
        }

    }
}
