using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    internal class Class1
    {
        public List<Class2> Id_A { get; set; }
        public List<Class3> Name_B { get; set; }
        public List<Class4> Address_C { get; set; }
        public List<Class5> Email_D { get; set; }
        public List<Class6> PhoneNo_E { get; set; }

        public List<int> Allowed_F { get; set; }



    }
    public class Class2 {      public int Id { get; set; }               }
    public class Class3 {      public string Name { get; set; }             }
    public class Class4 {      public string Address { get; set; }         }
    public class Class5 {       public string Email { get; set; }         }
    public class Class6 {       public long PhoneNo { get; set; }        }





}
