using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_1
{
    public class Lists2
    {
        public static void Main(string[] args)
        {

            List<Class1> list = new List<Class1>();

            Class1 obj1 = new Class1();
            obj1.Myprop = 100;      //set first property of Class1

            Console.WriteLine("++++++++++++ List as Datatype ++++++++++++++");
            obj1.Mylist = new List<Class2>();// upar hum direct value de sakte the par yaha humko constructor ke through values deni padengi

            //obj1.Mylist = new List<Class2>() {

            //   new Class2{ Myprop1 = 100 }

            //};


            Class2 obj2 = new Class2(); // list wala datatype ki class class2 me hai so uska constructor banayenge

            obj2.Myprop1 = 500;
            obj1.Mylist.Add(obj2);  // class1 wali list me value add hui hai 

            Console.WriteLine("++++++++++++ Class as Datatype ++++++++++++++");

            Class3 obj3 = new Class3();
            obj1.class3 = new Class3();
          // obj3.Myprop2 = 1000;            // we cannot write this 
            obj1.class3.Myprop2=1000;        // write this 
           

            list.Add(obj1);  // main list me values add kiya

            Console.WriteLine("+++++++ Printing Main List+++++++++");

            foreach (var xx in list)
            {

                Console.WriteLine(xx.Myprop);

                foreach(var yy in xx.Mylist)    // method to print list values from another list 
                {
                    Console.WriteLine(yy.Myprop1);

                 }
                Console.WriteLine(xx.class3.Myprop2);  // method to print the class values from another class
                


            }
            Console.ReadLine();
        }



    }


    public class Class1 {
    

        public int Myprop {  get; set; }    

        public List<Class2> Mylist { get; set;}

        public Class3 class3 { get; set; } 

    
    }
    public class Class2 { 
    
    public int Myprop1 { get; set; }
    }
    public class Class3 {
        public int Myprop2 { get; set; }
    }
}
