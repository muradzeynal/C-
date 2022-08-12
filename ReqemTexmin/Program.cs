using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqemTexmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int texmin = 0, saygac = 0;
            Random myNum = new Random();
            int reqem = myNum.Next(0, 100);
            Console.WriteLine("******Number Game******");
            Console.WriteLine("0-100 arasi reqem texmin edin!");
            while (texmin != reqem)
            {
                saygac++;
                texmin = Convert.ToInt32(Console.ReadLine());

                if (texmin > reqem)
                {
                    Console.WriteLine($"{texmin} den kicik reqem daxil edin");
                }
                else if (texmin < reqem)
                {
                    Console.WriteLine($"{texmin} den boyuk reqem daxil edin");
                }


            }
            Console.WriteLine($"Tebrikler siz {saygac} defeye duzgun tapdiniz!");
            Console.Read();
        }
       
    }
}
