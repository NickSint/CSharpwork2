using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpwork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();  //Очищяет текст и закрашивает вест фон
            Console.WriteLine("Hello world!"); //WriteLine приписка Line переносит на след. строчку курсор
            
            Console.WriteLine("c=(a+b)*(a-23*z)");

            string soov = Console.ReadLine();  //Создает переменую которую вводит пользаватель, P.s input на Phyton
            int c = 0;
            int a = 0;
            int b = 0;
            int z = 0;
            if (soov == "jah") // если переменая равна "да" то...
            {
                Console.WriteLine("c=");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("a=");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b=");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("z=");
                z = Convert.ToInt32(Console.ReadLine());

            }
            
            c = ((a + b) * (a - 23 * z));

            Console.WriteLine(c);
           
            Console.ReadLine(); //Не закрывает программу
        
                
                
                
                
                
                
              
        }  
           
        
            


            

    }
        
    
}
