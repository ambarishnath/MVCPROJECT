using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp

{

    public class Lists
    {
        public static void Main(string[] args)
        {
            List<Temp1> temp1 = new List<Temp1>();
            Temp1 tempr = new Temp1();
            tempr.Myprop = 100;
            tempr.b = 200;
            temp1.Add(tempr); // 2 properties add kar diya abhi ek property baki hai wo niche karenge
            
            Class1 pp = new Class1();
            pp.MyProperty = 100;
            pp.MyProperty2 = 45.77f;
            pp.MyProperty1 = "ttttt";

            tempr.abhi = new List<Class1>(); //Temp1 class se Class1 ko access karne ke liye ye line jaroori hai
            tempr.abhi.Add(pp); 

            foreach(var item in temp1)
            {
                // print first item of Class Temp1
                Console.WriteLine(item.Myprop);
                // Console.WriteLine(item);;  ye syntax galat hai upar wala sahi hai print karane ke liye
               
                
                //print second item of Class Temp1
                Console.WriteLine(item.b);


                //print third item of Class Temp1
                foreach(var item1 in item.abhi)    //abhi variable ke ander ki chije access karne ke liye loop chalana padega kyoki agar abhi ka datatype list<> ki jagah int hota to hum simply 'item.abhi' se usko access kar lete lekin iss case me abhi ka datatype list type ka hai so foreach loop se access karna padega
                {
                    Console.WriteLine(item1.MyProperty1);
                    Console.WriteLine(item1.MyProperty);
                    Console.WriteLine(item1.MyProperty2);

                }

            }
            Console.ReadLine();
        }


    }
    public class Temp1
    {
        // first item of Class Temp1
        public int Myprop {  get; set; }

        // second item of Class Temp1
        public int b;

        // third item of Class Temp1
        public List<Class1> abhi { get; set; }

    }
    public class Class1
    {
       public int MyProperty { get; set; }  
        public string MyProperty1 { get; set; } 

        public float MyProperty2 { get; set; }  

    }
   
}
