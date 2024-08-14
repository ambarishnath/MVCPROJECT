using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_1
{
    internal class pattern
    {

        static void Main(string[] args)
        {

               //*********
               // *********
               //  *********
               //   ********* 
               //    *********
               //     *********
               //      *********
               //       *********



            for (int i = 0;i<8;i++) { 
               for (int j = 0;j<=i;j++) {

                    Console.Write(" ");
                }
               for (int k = 0; k <= 8; k++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();



            }
            Console.ReadLine();
        }

    }
}
