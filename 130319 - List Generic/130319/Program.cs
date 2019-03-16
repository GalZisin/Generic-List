using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130319
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProtectedUniqueList<string> uniqueList = new MyProtectedUniqueList<string>("activation");
            try
            {
                uniqueList.Add("G");
                uniqueList.Add("K");
                uniqueList.Add("Z");
                uniqueList.Add("A");

               // uniqueList.Remove("Key5");
                foreach(string w in uniqueList)
                {
                    Console.WriteLine(w);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine();
            try
            {
                uniqueList.Sort("GALactivation");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine();
            try
            {
                uniqueList.Clear("GALactivation");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine();
            Console.WriteLine(uniqueList);
            Console.ReadLine();
        }
           
        
    }
}
