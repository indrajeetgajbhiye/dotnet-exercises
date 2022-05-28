using System;

namespace Exercises
{
    // classname
    class SquareOfTwo 
    {
        int num1;
        int num2;
        int sumOfSquare;
        // costructor
        public SquareOfTwo(int a, int b){
            num1 = a;
            num2 = b;
            sumOfSquare = getSquare(num1) + getSquare(num2);
        }
        // Method to get square
        public int getSquare(int num){
            return num*num ;
        }
        public static void Main(string[] args)
        {
            int a , b;

            Console.WriteLine("Enter number 1");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            b = Convert.ToInt32(Console.ReadLine());

            SquareOfTwo obj = new SquareOfTwo(a, b);

            if(obj.sumOfSquare > 100)
            {
                Console.WriteLine("The Numbers are "+ obj.num1+ " and "+ obj.num2);
            }
            else
            {
                Console.WriteLine("Square of two numbers is: "+ obj.sumOfSquare);
            }
        }
    }
}
