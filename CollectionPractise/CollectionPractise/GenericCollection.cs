using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractise
{
    internal class GenericCollection
    {
        public static void ListPractise()
        {
            List<string> strlist = new List<string>();
            strlist.Add("Hiii");
            strlist.Add("Hello");

            foreach (string str in strlist)
            {
                Console.WriteLine(str);
            }

        }


        //****Dictionary*******
        public static void DictionaryPractise()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "asp.net");
            dct.Add(4, "ado.net");


            //foreach(var key in dct.Keys)
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key);
            }
        }

        //*****SortedList*********

        public static void SortedListPractise()
        {
            SortedList<string, string> str = new SortedList<string, string>();
            str.Add("ora", "oracle");
            str.Add("vb", "vb.net");
            str.Add("cs", "cs.net");
            str.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in str)
            {
                Console.WriteLine(kvp.Key);
            }
        }

        //*******Stack*******
        public static void StackPractise()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("ado.net");

            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
        }

        //********Queue*******
        public static void QueuePractise()
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("cs.net");
            que.Enqueue("vb.net");
            que.Enqueue("asp.net");
            que.Enqueue("ado.net");

            foreach (var element in que)
            {
                Console.WriteLine(element);
            }
        }

    }
}
