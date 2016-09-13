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
                        var p = new Plus();
                        p.Result(first, second);
                    }
                else if (choice == 2)
                    {
                        var m = new Minus();
                        m.Result(first, second);
                    }
                else if (choice == 3)
                    {
                        var u = new Multiply();
                        u.Result(first, second);
                    }
                else if (choice == 4)
                    {
                        var d = new Division();
                        d.Result(first, second);
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
