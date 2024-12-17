// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CollectionPractise
{
    class program
    {
        static void Main(string[] args)
        {   //GenericCollection obj = new GenericCollection();
            //int defaultInt = utility.GetDefault<int>();

            //int Result = obj.List<string>();

            //GenericCollection.ListPractise();
            GenericCollection.DictionaryPractise();
            GenericCollection.SortedListPractise();
            GenericCollection.StackPractise();
            GenericCollection.QueuePractise();

            NonGenericCollection.ArrayListPractise();
            NonGenericCollection.HashTablePractise();
            NonGenericCollection.SortedListPractise();
            NonGenericCollection.StackPractise();
            NonGenericCollection.QueuePractise();
        



        }
    }
}
