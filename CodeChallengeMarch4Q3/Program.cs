using System;
using System.Collections;

namespace CodeChallengeMarch4Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrequencyCount();
        }
        static void FrequencyCount()
        {
            string words = "the day is sunny the the the sunny is is";

            string[] newWords= words.Split(' ');

            Hashtable table = new Hashtable();
            for (int i = 0; i < newWords.Length; i++)
            {
                if (table.ContainsKey(newWords[i]))
                {
                    table[newWords[i]] = i + 1;
                }
                else
                {
                    table.Add(newWords[i], 1);
                }
            }
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
