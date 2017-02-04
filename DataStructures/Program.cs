using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new ArrayList<string>();
            Console.WriteLine("ArrayList count = {0}\r\nArrayList size = {1}", list1.Count, list1.Size);

            list1.Add("Hello");
            list1.Add("I'm");
            list1.Add("An");
            list1.Add("ArrayList");
            Console.WriteLine("ArrayList count = {0}\r\nArrayList size = {1}", list1.Count, list1.Size);

            for (var i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            list1.Add("Now");
            list1.Add("I'm");
            list1.Add("Bigger");
            Console.WriteLine("ArrayList count = {0}\r\nArrayList size = {1}", list1.Count, list1.Size);

            for (var i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
        }
    }
}
