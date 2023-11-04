// See https://aka.ms/new-console-template for more information


//Тема: Делегати (delegate)
//public delegate void MyDelegate(int n1, int n2); 

using Lesson_28_10;

Func<int,string> myFunc = x =>  x.ToString();
Console.WriteLine(myFunc(100));


Action<double> myAction2 = x => Console.WriteLine(x);

Action<int, string> myAction = 
    (x, s) =>  Console.WriteLine($"Received {x} and {s}");



myAction += MyMath.TestAction;
myAction(42, "Hello");


//MyDelegate[] arr = new MyDelegate[5] { 
//    MyMath.Sum, MyMath.Mul, MyMath.Sum, MyMath.Substraction, MyMath.Sum 
//};

//foreach(var el in arr)
//{
//    el.Invoke(4, 5);
//}

//MyDelegate objDel = new MyDelegate(MyMath.Sum);
//objDel += MyMath.Substraction;
//objDel += MyMath.Mul;
//objDel += MyMath.Sum;

//foreach(var i in objDel.GetInvocationList())
//{
//    Console.WriteLine(i.Method.Name);

//}

//objDel = MyMath.Sum;

//objDel.Invoke(4, 5);

//foreach (var i in objDel.GetInvocationList())
//{
//    Console.WriteLine(i.Method.Name);
//}

//objDel?.Invoke(4, 5);

//objDel(2, 5);
