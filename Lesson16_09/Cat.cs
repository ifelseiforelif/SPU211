using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson16_09
{
    internal struct Cat
    {
        private string _name;
        private int _age;
        private bool _isExist;

        public Cat(string name, int age)
        {
            _name = name;
            _age = age;
            _isExist = true;
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

        public void ShowCat()
        {
            Console.WriteLine($"Cat. Name {_name}. Age {GetAge()}. IsExist {_isExist}");
        }
    }
}
