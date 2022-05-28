using System;

namespace Exercises
{
    class Discounts
    {

        int DiscountA { get; set; }
        int DiscountB { get; set; }
        public Discounts(int a, int b){
            DiscountA = a;
            DiscountB = b;

            Console.WriteLine("Discount of A is : "+ (DiscountA > 5000 ? printDiscount(DiscountA, 5): 0));
            Console.WriteLine("Discount of B is : "+ (DiscountB > 10000 ? printDiscount(DiscountB, 7): 0));
        }

        public float printDiscount(int orderValue, int dicountRate){
            return (float)(orderValue * dicountRate)/100;
        }
        public static void Main(string[] args){
            int a, b;
            Console.WriteLine("Enter the value of A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of B");
            b = Convert.ToInt32(Console.ReadLine());
            Discounts dsc = new Discounts(a, b);
        }
    }
}