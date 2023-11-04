using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_09
{
    public class Dog
    {
        private string _name;
        private int _age;

        public Dog(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetName()
        {
            return _name;
        }
        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age) 
        {
            _age = age;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void ShowDog()
        {
            Console.WriteLine($"Dog. Name {_name}. Age {GetAge()}");
        }
    }
}
