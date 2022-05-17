using System;

namespace HasTable
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            Console.WriteLine("Select Number:\n1.Uc1-To Be Or Not To Be\n" +"2.Uc2-Finding Frequency  in a large Paragraph");
            int option = Convert.ToInt32(Console.ReadLine());
            string write = Console.ReadLine();
            while (true)
            {
                switch (option)
                {
                    case 1:
                        MyMapNode<string, int> hashTable = new MyMapNode<string, int>(7);
                        hashTable.Add("To", 1);
                        Console.WriteLine("To->" + hashTable.Get("To"));
                        hashTable.Add("be", 2);
                        Console.WriteLine("Be->" + hashTable.Get("be"));
                        hashTable.Add("Or", 3);
                        Console.WriteLine("Or->" + hashTable.Get("Or"));
                        hashTable.Add("not", 4);
                        Console.WriteLine("not->" + hashTable.Get("not"));
                        hashTable.Add("to", 5);
                        Console.WriteLine("to->" + hashTable.Get("to"));
                        hashTable.Add("be", 6);
                        Console.WriteLine("be->" + hashTable.Get("be"));
                        Console.WriteLine("Select a key (to be or not to be) for get value: " + hashTable.Get(write));
                        Console.ReadLine();
                        break;
                    case 2:
                        string Uc2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        string[] LenghtOfParagraph = Uc2.Split(" ");//splits a string into an array of strings
                        int tableSize = LenghtOfParagraph.Length;//used to get the number of characters/string in the current String
                        MyMapNode<int, string> hashTable1 = new MyMapNode<int, string>(tableSize);
                        int getIndex = 0;
                        foreach (string words in LenghtOfParagraph)
                        {
                            hashTable1.Add(getIndex, words);
                            getIndex++;
                        }
                        for (getIndex = 0; getIndex < tableSize; getIndex++)
                        {
                            string word = hashTable1.Get(getIndex);
                            Console.WriteLine(word + "---->" + getIndex);

                        }
                        break;
                    default:
                        Console.WriteLine("Option is wrong");
                        break;
                }
            }
            
        }
    }
}
