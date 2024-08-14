using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_1
{
    public abstract class ANS          // we cannot create object of abstract class
    {
       public  abstract void Ans();    // this should not be private kyoki isko kahi pe define karna hai
                                       // Ans() ka A capital letter hona chahiye

        public int AAA(int a , int b)             // abstract class me normal method ko body deni padti hai
        {
            return a + b;
        }


    }

    class AANNSS : ANS           // Jo class AbstractANS ko inherit karegi usko Abstract Ans() function ko override use karke body deni padegi 
    {
        public override void Ans()
        {
            AAA(1,2);
        }


    }
    internal class Abstraction
    {

        static void Main(string[] args)
        {
            AANNSS obj = new AANNSS();

            obj.Ans();

            Console.ReadLine(); 
        }


    }
}
