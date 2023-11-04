// See https://aka.ms/new-console-template for more information


using Lesson30_09;



Transport tr = new Airplane("");
if(tr is Airplane pl)
{
    pl.Fly();
}


//IFlyable air = new Airplane("");

////Car obj = (Car)air; //exception

////Car? air2 = (air as Car);

//if(air is Airplane)
//{
//    Airplane? air2 = (air as Airplane);
//    air2?.Move();
//}




//Player player = new Player("Oleg");

//Transport? tr = null;

//Console.WriteLine("1- Car, 2-Bike, 3-Airplane");
//int choice = Convert.ToInt32(Console.ReadLine());
//switch (choice)
//{
//    case 1:
//        tr = new Car("opel");
//        break;
//    case 2:
//        tr = tr = new Bike("test");
//        break;
//    case 3:
//        tr = tr = new Airplane("test");
//        break;
//}
//if (tr != null)
//{
//    player.Drive(tr);
//}



//int? n = 8;
//Console.WriteLine((n ?? 100));
//Console.WriteLine(n);

//Transport transport = new Transport();
//transport.Model = "audi";
//Console.WriteLine(transport.Model?.Length);

//var n = 10; //в С++ auto
//n = "Hello World";
//dynamic n = 10;
//Console.WriteLine($"Value {n}. Type: {n.GetType()}");
//n = 9.6;
//Console.WriteLine($"Value {n}. Type: {n.GetType()}");
//n = "Hello World";
//Console.WriteLine($"Value {n}. Type: {n.GetType()}");
