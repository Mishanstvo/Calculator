using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
  
 public  class Calculator{
        
        public int Plus(int first, int second)
         {
             Console.WriteLine("Результат:");
             Console.WriteLine(first + second);
             int result = first + second;
             return result;
         }
        public int Minus(int first, int second)
        {
            Console.WriteLine("Результат:");
            Console.WriteLine(first - second);
            int result = first - second;
            return result;
        }
        public int Multiply(int first, int second)
        {
            Console.WriteLine("Результат:");
            Console.WriteLine(first * second);
            int result = first * second;
            return result;
        }
        public int Division(int first, int second)
        {
            Console.WriteLine("Результат:");
            Console.WriteLine(first / second);
            int result = first / second;
            return result;
        }
      
 }
     


   
}


