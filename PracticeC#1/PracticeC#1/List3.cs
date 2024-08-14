using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_1
{
    internal class List3
    {

      



       

       
        static void Main(string[] args)
        {
            Employees employee1 = new Employees()
            {

                Name = "ambarish",
                Age = 24,
                Designation = "MANAGER"
            };

            Employees employee2 = new Employees()
            {
                Name = "Arunesh",
                Age = 22,
                Designation = "COOWNER"


            };


            List<Employees> obj = new List<Employees>();

            obj.Add(employee1);
            obj.Add(employee2); 


            foreach (Employees xyz in obj)
            {
                Console.WriteLine(xyz.Name);
                Console.WriteLine(xyz.Age);
                Console.WriteLine(xyz.Designation);
                Console.WriteLine("Also Try This");
                Console.WriteLine("Name is {0}, Age is {1}, Designation is {2}",xyz.Name,xyz.Age,xyz.Designation);

            }
            Console.ReadLine();

        }


    }

    class Employees
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
    }
} 
