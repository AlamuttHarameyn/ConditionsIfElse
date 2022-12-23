using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Şart bloklarında mantıksal operatörler kullanılır.
            var number = 20;
            if (number == 10) //İf şart bloğu şart gerçekleşyorsa çalıştırır. 
            {
                Console.WriteLine("Number is 10");
            }

            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            
            else //Değilse demektir.Şart gerçekleştirmiyorsa çalıştırır.
            {

                Console.WriteLine("Number is not 10 or 20");
            }
            Console.ReadKey();
        }
    }
}
