using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractise
{
    internal class NonGenericCollection
    {    //****ArrayList***
        public static void ArrayListPractise()
        {
            ArrayList lt = new ArrayList();
            lt.Add(1);
            lt.Add("Priya");
            lt.Add("DateTime.Now");

            foreach (var element in lt)
            {
                Console.WriteLine(element);
            }

        }

        //***HashTable***
        public static void HashTablePractise()
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (var element in ht)
            {
                Console.WriteLine(element);
            }
        }

        //****SortedList***
        public static void SortedListPractise()
        {
            SortedList s1 = new SortedList();
            s1.Add("ora", "oracle");
            s1.Add("vb", "vb.net");
            s1.Add("cs", "cs.net");
            s1.Add("asp", "asp.net");

            foreach (var element in s1)
            {
                Console.WriteLine(element);
            }

        }

        //*******Stack*****
        public static void StackPractise()
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (var element in stk)
            {
                Console.WriteLine(element);
            }
        }

        //********Queue*******
        public static void QueuePractise()
        {
            Queue que = new Queue();
            que.Enqueue("cs.net");
            que.Enqueue("vb.net");
            que.Enqueue("asp.net");
            que.Enqueue("sqlserver");

            foreach (var element in que)
            {
                Console.WriteLine(element);
            }

        }



    }






    
}
