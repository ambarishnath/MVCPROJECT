using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    interface Ia
    {
         List<Class1> GetEmployees();   // yaha specifier nahi likhte hai & na hi abstract likhte hai

    }
     class Program : Ia
    {
        public List<Class1> GetEmployees() {
          // List<Class1> list = new List<Class1>();

            List<Class1> list1 = new List<Class1>() { new Class1() {  Id_A= new List<Class2>() { new Class2() { Id=1 } } ,
                Name_B= new List<Class3> { new Class3() { Name = "Ambarish"} } ,
                Address_C=new List<Class4>{ new Class4() { Address ="Noida" } } ,
                Email_D= new List<Class5>{ new Class5() { Email= "ambarishnathsingh@gmail.com" } },
                PhoneNo_E= new List<Class6>{ new Class6() { PhoneNo= 7355225630 } },
                Allowed_F = new List<int>{ 10 }     // agar list ka datatype class ki jagah simply int ho to

            } };


           


            return list1;
        
        }  
        static void Main(string[] args)
        {
              Program obj = new Program();
            List<Class1> list = obj.GetEmployees();   // ye line likna jaroori hai


            // list and class ke ander ghuste chale jao jabtak property set karne tak na pahuch jao

            //List<Class1> list = new List<Class1>() { new Class1() {  Id_A= new List<Class2>() { new Class2() { Id=1 } } ,
            //    Name_B= new List<Class3> { new Class3() { Name = "Ambarish"} } ,
            //    Address_C=new List<Class4>{ new Class4() { Address ="Noida" } } ,
            //    Email_D= new List<Class5>{ new Class5() { Email= "ambarishnathsingh@gmail.com" } },
            //    PhoneNo_E= new List<Class6>{ new Class6() { PhoneNo= 7355225630 } },
            //    Allowed_F = new List<int>{ 10 }     // agar list ka datatype class ki jagah simply int ho to


            //} };

            foreach(Class1 obj1 in list)
            {
                foreach(Class2 obj2 in obj1.Id_A)
                {
                    Console.WriteLine(obj2.Id);
                }
                foreach (Class3 obj3 in obj1.Name_B)
                {
                    Console.WriteLine(obj3.Name);
                }
                foreach (Class4 obj4 in obj1.Address_C)
                {
                    Console.WriteLine(obj4.Address);
                }
                foreach (Class5 obj5 in obj1.Email_D)
                {
                    Console.WriteLine(obj5.Email);
                }
                foreach (Class6 obj6 in obj1.PhoneNo_E)
                {
                    Console.WriteLine(obj6.PhoneNo);
                }

                foreach(var obj7 in obj1.Allowed_F)
                {
                    Console.WriteLine(obj7);

                }

                // now we have to copy the values of class1 in Class7
                Class1 class1 = new Class1();   
                Class7 class7 = new Class7();

                class7.Id_A = class1.Id_A.Select(a => new Class8 { Id = a.Id }).ToList();   



            }


            Console.ReadLine();
        }
    }
}
