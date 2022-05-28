using System;
namespace Exercises{
    class PrintNumbers{
        public PrintNumbers(){
            for (int i = 11; i <= 100; i++){
                Console.Write(i + "\t");
                if (i%10 == 0){
                    Console.Write("\n");
                }
            }
        }
        public static void Main(string[] args){
        
            PrintNumbers pr1 = new PrintNumbers();
        }

    }
}