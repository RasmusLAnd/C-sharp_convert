using System;

namespace C_sharp_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Øvn.1 - multiplication
            double numberOne, numberTwo, result;

            Console.WriteLine("Enter value number one: ");
            Double.TryParse(Console.ReadLine(), out numberOne);

            Console.WriteLine("Enter value number two: ");
            Double.TryParse(Console.ReadLine(), out numberTwo);

            result = numberOne*numberTwo;

            Console.WriteLine($"{numberOne} * {numberTwo} = {result}");
            Console.ReadKey();

            //round input
            double inputUser, result2;

            Console.WriteLine("enter a decimel number:");
            Double.TryParse(Console.ReadLine(), out inputUser);

            result2 = Convert.ToInt32(inputUser);
            Console.WriteLine(result2);
            Console.ReadKey();

            //øvn 3 - switch with Q&A
            char answer;
            Console.WriteLine("Är det fint väder?");
            answer = Console.ReadKey().KeyChar;
            
            Console.WriteLine();

            /*switch(answer)
            {
                case 'j':
                    Console.WriteLine("Take a picknick");
                    Console.ReadKey();
                break;

                case 'n':
                    Console.WriteLine("read a book");
                    Console.ReadKey();
                break;

                default:
                    Console.WriteLine("I don't understand");
                    Console.ReadKey();
                break;
            
            } */       
        }
    }
}
