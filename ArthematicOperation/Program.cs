using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ArthematicOperation
{
    class Program
    {
        public static object FirstNumber { get; private set; }
        public static object SecondNumber { get; private set; }

        static void Main(string[] args)
        {
            double FirstNumber;
            double SecondNumber;
            double answer;
            string Operator;
            while (true)
            {


                Console.WriteLine("Welcome to my Calculator");


                Console.WriteLine("Enter First Number");
                FirstNumber = Double.Parse(Console.ReadLine());

                Console.WriteLine("Select an operator: (+, -, %, *, /)");
                Operator = Console.ReadLine();


                Console.WriteLine("Enter second Number");
                SecondNumber = Double.Parse(Console.ReadLine());

                Console.WriteLine("Answer");
                if (Operator == "+")
                {
                    answer = FirstNumber + SecondNumber;
                    Console.Write(answer);
                }
                if (Operator == "-")
                {
                    answer = FirstNumber - SecondNumber;
                    Console.Write(answer);

                }
                if (Operator == "/")
                {
                    answer = FirstNumber / SecondNumber;
                    Console.Write(answer);

                }
                if (Operator == "*")
                {
                    answer = FirstNumber * SecondNumber;
                    Console.Write(answer);
                }


                Console.WriteLine("\nExchange Numbers ");
                var temp = FirstNumber;
                FirstNumber = SecondNumber;
                Console.Write(FirstNumber);
                Console.WriteLine("\nExchange Numbers");
                SecondNumber = temp;
                Console.Write(SecondNumber);

                Console.WriteLine("\nExit");


            }
        }
        private static void Exchange()
        {
            var temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;

        }
    }
}
