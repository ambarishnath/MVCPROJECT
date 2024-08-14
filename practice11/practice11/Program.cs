using System;
using System.Numerics;
using System.Threading.Channels;

namespace XYZ
{
    class XYZ
    {

        static void Main(string[] args)
        {

            //int x = 10;
            //int y = 20; 
            //Console.WriteLine(x+y);   



            //bool z= true;
            //bool y= false;

            //int a = Convert.ToInt32(z);
            //int b = Convert.ToInt32(y);
            //Console.WriteLine("{0},{1}",a,b);   



            // console stopper

            //bool Flag = true;

            //do { 
            //    int a = 2 + 3;
            //    Console.WriteLine(a);
            //   Flag = Convert.ToBoolean(Console.ReadLine());
            //}
            //while ( Flag ==true);


            // increment decrement


            //int i = 10;
            //Console.WriteLine(i);    //10  // i ki value continuous update hoti rahegi
            //Console.WriteLine(i++); //10
            //Console.WriteLine(++i); //12 
            //Console.WriteLine(i--); //12 
            //Console.WriteLine(--i); //10




            // Binary To Decimal

            //string AB = Console.ReadLine();
            //string AB = "111";
            //char[] AA = AB.ToCharArray();

            //double sum = 0;
            //for (int i =  0; i <AA.Length; i++) {

            //        if (AA[i] == '1') {
            //            sum = sum + Math.Pow(2,(AA.Length-1)-i );

            //        }
            //        else if (AA[i] == '0')
            //        {
            //            continue;

            //        }
            //    }

            //Console.WriteLine(sum);


            // number  is equal to sum of two parts of that number's  square is KARPERKAR NUMBER



            double n = 45;
            double square = n * n; //2025
           // double x= 0;
           // double y= 0;   
            double z= 10;
            //double zz = 0;
            while (true )
            {
                Console.WriteLine(" karpekar number");
               double x = square % z;   

              double  zz = square / z;

              double  y= zz + x;

                if (y == n)
                {
                    Console.WriteLine("it is karpekar number");
                    break;
                }
                else { 
                    z = z * z;
                   
                }
            }


            Console.ReadLine();

            
        }


    }




}