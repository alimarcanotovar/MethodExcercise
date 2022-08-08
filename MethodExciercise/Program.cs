using System;

namespace MethodExciercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your name?" );
            var name = Console.ReadLine();

            Console.WriteLine("what is your favorite color" );
            var color = Console.ReadLine();

            Console.WriteLine("what is your favorite animal");
            var animal = Console.ReadLine();
            
            Console.WriteLine("what is your favorite band");
            var band = Console.ReadLine();

            Console.WriteLine($"Hi my name is {name},my favorite is {color},my spirit animal is {animal},and I love to listen to {band}"); 

             static int Add(int x, int y)
            {

               return ( x + y );
                



            }
            Console.WriteLine(Add(1, 3));

             static int Sub(int x, int y)
            {

                return  ( x - y );



            }
            Console.WriteLine(Sub(1, 3));

             static int Multiply(int x, int y)
            {


                return x * y;

            }
            Console.WriteLine(Multiply(1, 3));

             static int Divide(int x, int y)
            {


                return x / y;

            }
            Console.WriteLine(Divide(1, 3));

            static bool IsEven(int x)
            { return x % 2 == 0; }
            Console.WriteLine(IsEven(10));







        }
    }
}
