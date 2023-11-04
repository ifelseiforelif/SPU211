// See https://aka.ms/new-console-template for more information

using Lesson_04_11.Model;

Phone phone = new Phone("TestModel", 78662);

phone.AppearancePhoneEvent += Subscriber1.BuyPhone;
phone.AppearancePhoneEvent += Subscriber2.BuyPhone;

phone.AppearancePhone(phone.Model);


phone.AppearancePhoneEvent -= Subscriber1.BuyPhone;

phone.AppearancePhone(phone.Model);

