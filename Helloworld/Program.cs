// To run this do dotnet run in the HelloWorld folder
// Console.WriteLine == print()
// Console.ReadLine() == input()
// var variables can be equaled to anything like with python variables, does not need to defined a variable unless you want to
// Environment.NewLine like new line in strings but since dotnet is combatitble with different Environment.NewLine uses that
//  platforms newline command

using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
