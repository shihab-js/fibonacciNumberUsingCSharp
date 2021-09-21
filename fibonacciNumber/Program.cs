using System;

namespace fibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int n1 = 0, n2 = 1, n3, number;

            //Message to users
            Console.Write("Enter the number of elements: ");

            //input from the users
            number = int.Parse(Console.ReadLine());
            
            //print the first two numbers
            Console.Write(n1 + " " + n2 + " ");

            //continue the program until equal to user input
            for(int i=2; i<number; ++i)
            {
                n3 = n1 + n2;
                //print the number
                Console.Write(n3 + " ");
                //swap the numbers
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
