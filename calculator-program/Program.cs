using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          do {
          double num1 = 0;
          double num2 = 0;
          double result = 0;

          Console.WriteLine("--------------------------------");
          Console.WriteLine("Calculator Program");
          Console.WriteLine("--------------------------------");

          Console.Write("Enter the first number: ");
          num1 = Convert.ToDouble(Console.ReadLine());

          Console.Write("Enter the second number: ");
          num2 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Enter the operation: ");
          Console.WriteLine("\t+ Add");
          Console.WriteLine("\t- Subtract");
          Console.WriteLine("\t* Multiply");
          Console.WriteLine("\t/ Divide");

          switch (Console.ReadLine()) {
            case "+":
              result = num1 + num2;
              Console.WriteLine("The result : " + num1 + " + " + num2 + " = " + result);
              break;
            case "-":
              result = num1 - num2;
              Console.WriteLine("The result : " + num1 + " - " + num2 + " = " + result);
              break;
            case "*":
              result = num1 * num2;
              Console.WriteLine("The result : " + num1 + " * " + num2 + " = " + result);
              break;
            case "/":
              result = num1 / num2;
              Console.WriteLine("The result : " + num1 + " / " + num2 + " = " + result);
              break;
            default:
              Console.WriteLine("Invalid operation");
              break;
          }
          Console.WriteLine("Do you want to continue? (Y/N)");
          } while (Console.ReadLine().ToUpper() == "Y");
          
          Console.WriteLine("Thank you for using the calculator!");

          Console.ReadKey();
        }
    }
}

// dotnet new console pour créer un nouveau projet console
// dotnet run pour exécuter le programme
// dotnet build pour compiler le programme