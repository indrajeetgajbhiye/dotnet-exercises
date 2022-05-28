using System;
namespace Exercises{
    class PrimeNumber{
        int Number{ get; set; }
        public bool IsComposite{ get; set; }


        public PrimeNumber(int num){
            Number = num;
            IsComposite = false;
            if(Number< 0){
                Console.WriteLine("Number is not positive");
            }
            else if(Number == 0 || Number == 1){
                Console.WriteLine("Number is neither prime nor composite");
            }
            else{   
                for (int i = 2; i <= Math.Sqrt(Number); i++){
                    if (Number % i == 0){
                        IsComposite = true;
                        break;
                    }
                }
            }


            
        }
        public static void Main(string[] args){
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            PrimeNumber pr = new PrimeNumber(num);
            if(pr.IsComposite){
                Console.WriteLine("Number is not prime");
            }
            else{
                Console.WriteLine("Number is prime");
            }
        }
    
    }
}