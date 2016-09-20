using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int first, second, choice;
                var p = new Calculator();
                while (true)
                {
                    //   a= Console.ReadLine();
                    Console.WriteLine("Выберите операцию:");
                    Console.WriteLine("1:+");
                    Console.WriteLine("2:-");
                    Console.WriteLine("3:*");
                    Console.WriteLine("4:/");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите первое число:");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    second = Convert.ToInt32(Console.ReadLine());
          
                 if (choice == 1)
                    {
                       
                        p.Plus(first, second);
                    }
                else if (choice == 2)
                    {
                      
                        p.Minus(first, second);
                    }
                else if (choice == 3)
                    {
                       
                       p.Multiply(first, second);
                    }
                else if (choice == 4)
                    {
                       
                        p.Division(first, second);
                    }

            }
                    catch
                    {
                        Console.WriteLine("Ошибка");

                    }
              } 
           
        }
    }
}
