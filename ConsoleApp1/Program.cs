using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            int score2 = 0;

            do
            {

                string a = Console.ReadLine();
                bool result = int.TryParse(a, out score);
                if (result == true && score>0 && score%2!=0 )
                {
                    
                    score2 += score;


                }
            }

                 while (score != 0);
                {

                    Console.WriteLine(score2);
                    Console.ReadKey();
                    
                }



            
        }
    }
}
