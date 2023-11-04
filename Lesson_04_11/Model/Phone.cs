using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_11.Model
{
    public class Phone
    {
        public delegate void MyDelegate(string mes);
        //загальний сінитаксис створення Event
        //специфікаторДоступу event тіпДелегата і'мяПодії
        public event MyDelegate AppearancePhoneEvent;
        public string? Model { get; set; }
        public decimal Price { get; set; }
        public Phone(string m, decimal pr)
        {
            Model = m;
            Price = pr;
        }
        public void AppearancePhone(string message)
        {
            AppearancePhoneEvent?.Invoke(message);
        }

    }
}
