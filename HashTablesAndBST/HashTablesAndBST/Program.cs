using System;

namespace HashTablesAndBST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Create BTS \n2.Size Method in BTS \n3.Search Element \n4.Frequency Of Word" +
                "\n5.Frequency of word in paragraph \n6.Remove Avoidable Word");
            Console.WriteLine("Enter a option");
            int option = Convert.ToInt32(Console.ReadLine());
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            
            switch (option)
            {
                case 1:
                    {
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Display();
                        break;
                    }
                case 2:
                    {
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Insert(22);
                        binarySearch.Insert(40);
                        binarySearch.Insert(60);
                        binarySearch.Insert(95);
                        binarySearch.Insert(11);
                        binarySearch.Insert(65);
                        binarySearch.Insert(3);
                        binarySearch.Insert(16);
                        binarySearch.Insert(63);
                        binarySearch.Insert(67);
                        binarySearch.Display();
                        binarySearch.GetSize();
                        break;
                    }
                case 3:
                    {
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Insert(22);
                        binarySearch.Insert(40);
                        binarySearch.Insert(60);
                        binarySearch.Insert(95);
                        binarySearch.Insert(11);
                        binarySearch.Insert(65);
                        binarySearch.Insert(3);
                        binarySearch.Insert(16);
                        binarySearch.Insert(63);
                        binarySearch.Insert(67);
                        binarySearch.Display();
                        Console.WriteLine(binarySearch.Search(63, binarySearch));
                        break;
                    }

                case 4:
                    {
                        HashTables<int, string> HashTable = new HashTables<int, string>(5);
                        HashTable.Add(0, "To");
                        HashTable.Add(1, "Be");
                        HashTable.Add(2, "Or");
                        HashTable.Add(3, "Not");
                        HashTable.Add(4, "To");
                        HashTable.Add(5, "Be");

                        Console.WriteLine("Enter a word to find a frequency'To Be Or Not To Be'");
                        string word = Console.ReadLine();
                        Console.WriteLine("The frequency of " + word + " is: " + HashTable.FrequencyOfWords(word));
                        break;
                    }
                case 5:
                    {
                        {
                            string givenPhrase = "Paranoids are not paranoid because they " +
                                "are paranoid but because they keep putting themselves " +
                                "deliberately into paranoid avoidable situations";
                            string[] arrayOfPhrase = givenPhrase.Split(" ");
                            var distinctWords = arrayOfPhrase.Distinct();
                            int length = arrayOfPhrase.Length;
                            HashTables<int, string> HashTable = new HashTables<int, string>(arrayOfPhrase.Length);
                            int i = 0;
                            foreach (string data in arrayOfPhrase)
                            {
                                HashTable.Add(i, data);
                                i++;
                            }
                            foreach (string data in distinctWords)
                            {
                                Console.WriteLine(data + ": " + HashTable.FrequencyOfWords(data));
                            }
                            break;
                        }
                    }
                case 6:
                    {
                        string givenPhrase = "Paranoids are not paranoid because they are paranoid" +
                            " \n but because they keep putting themselves deliberately " +
                            "\n into paranoid avoidable situations";

                        string[] arrayOfPhrase = givenPhrase.Split(" ");
                        int length1 = arrayOfPhrase.Length;
                        HashTables<int, string> HashTable = new HashTables<int, string>(arrayOfPhrase.Length);
                        int j = 0;
                        foreach (string data in arrayOfPhrase)
                        {
                            HashTable.Add(j, data);
                            j++;
                        }

                        foreach (string data in arrayOfPhrase)
                        {
                            if (data == "avoidable")
                            {
                                HashTable.Remove(0);
                                continue;
                            }
                            Console.Write(String.Join("", data, " "));
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            }
        }
    }
}