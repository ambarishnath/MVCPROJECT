using System;
namespace ans
{
     class anss   // namespace ke baad wali class ko direct private nahi kar sakte hai isse sirf internal ya public kar sakte hai
    {
         static void main()   // iss main ka 'M -> m' bana do to dusri class run hogi jisme M bada hoga ya fir propreties  se entry point set kar do
        {
            Console.WriteLine("Enter First Number");
          //  int pq = Convert.ToInt32 (Console.ReadLine());
          string pq = Console.ReadLine();
            if(float.TryParse(pq , out float number))
            {
                Console.WriteLine(number);  

            }else { Console.WriteLine("Enter Float"); }

            

            Console.WriteLine("Enter Second Number");
            int ab = Convert.ToInt32(Console.ReadLine());

           //  int c =  Convert.ToInt32(number) + ab;
            float c = number + ab;

            Console.WriteLine(c);

            Console.ReadLine();


        }
    }



}