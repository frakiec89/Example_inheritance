// See https://aka.ms/new-console-template for more information
using Example_inheritance;



StudentServiceBase student = new StudentServiceBase(); 

Console.WriteLine("Привет в  каком  формате  будем работать ?");
Console.WriteLine("\"text\" - буду выводить собщение  в  файл");
Console.WriteLine("\"console\" - буду выводить собщение  в  консоль");

switch (Console.ReadLine())
{
    case "text":
        student = new StudentText(); break;
    case "console": student = new StudentConsole(); break;
        default : Console.WriteLine("Я  вас не понял"); return;
}


// эта логика меняться не будет 

student.Response();
