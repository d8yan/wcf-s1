using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string choice="";
            double n1, n2,n3;
            string email, pass,result;
            while (!choice.Equals("5"))
            {
                Console.WriteLine("\t\tCalculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Login");
                Console.WriteLine("6. which number is big?");
                Console.WriteLine("\t Enter your choice:");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Add(n1, n2);
                        Console.WriteLine("The sum is : " + n3);
                        break;
                    case "2":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Sub(n1, n2);
                        Console.WriteLine("The Sub is : " + n3);
                        break;
                    case "3":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Mul(n1, n2);
                        Console.WriteLine("The Multiplication is : " + n3);
                        break;
                    case "4":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        n3 = client.Div(n1, n2);
                        Console.WriteLine("The Divide is : " + n3);
                        break;

                    case "5":
                        Console.WriteLine("Enter email: ");
                        email = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        pass = Console.ReadLine();
                        result = client.Login(email, pass);
                        Console.WriteLine("The Divide is : " + result);
                        break;
                    case "6":
                        Console.WriteLine("Enter number 1: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        n2 = double.Parse(Console.ReadLine());
                        result = client.GreaterNumber(n1, n2);
                        Console.WriteLine("The Divide is : " + result);
                        break;
                   
                    default:
                        break;
                }
            }
           
        }
    }
}
