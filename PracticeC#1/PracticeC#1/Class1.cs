using System;

namespace ANSS
{

    class ANS
    {

        static void main()
        {
            /* // String Name = Convert.ToString(Console.ReadLine());   
              String Name = Console.ReadLine();   

              switch (Name.ToLower())
              {
                  case "ambarish": Console.WriteLine("ambarish"); break;
                  case "ans": Console.WriteLine("anss");break;
                  case "1111": Console.WriteLine("1112");break;
                      default: Console.WriteLine("Koi Aur"); break;    


              }  */


            //  Console.WriteLine("Enter A String");

            //  string name = "null";


            //  Console.WriteLine(name);
            ////  string a=name.ToString();




            //  Console.ReadLine();

            string myString = "Ambarishnath@singh1122";
            Console.WriteLine(myString.IndexOf("@"));
            for (int i = 0; i < myString.Length; i++)
            {
                if (i < myString.IndexOf("@"))
                {

                    Console.Write(myString[i]);

                 }
                if (i== myString.IndexOf("@")) { Console.WriteLine(); }


                if (i > myString.IndexOf("@") - 1)
                {
                    Console.Write(myString[i]);
                }


            }Console.ReadLine();    
        }
        

        }




    }



