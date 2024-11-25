// See https://aka.ms/new-console-template for more information
using Example_inheritance;


StudentConsole studentConsole = new StudentConsole();

Console.WriteLine("Привет в  каком  формате  будем работать ?");
Console.WriteLine("\"text\" - буду выводить собщение  в  файл");
Console.WriteLine("\"console\" - буду выводить собщение  в  консоль");

switch (Console.ReadLine())
{
    case "text":
        studentConsole.ResponseToText(); break;
    case "console": studentConsole.ResponseToConsole(); break ;
}



