using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.ArrayList list = new System.Collections.ArrayList();
            //list.Add("One");
            //list.Add("Two");
            //list.Add(1);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //int counter = 100000000;
            //List<string> guidString = new List<string>();

            //for (int i = 1; i <= counter; i++)
            //{
            //    string guid = Guid.NewGuid().ToString();//.Substring(0, 7);
            //    guidString.Add(guid);
            //}

            //var value = guidString.Distinct().Count();

            //Console.WriteLine(value);

            string empty = string.Empty;
            int test = 0;

            int.TryParse(ReturnEmptyString().ToString(), out test);

            Console.WriteLine(test);


            Console.ReadLine();
        }

        public static object ReturnEmptyString(){
            return string.Empty;
        }
    }
}
