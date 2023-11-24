using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpChallenge
{
    public class CountVowel
    {
        public void getVowelCount()
        {
            //enter string value eg Samuel
            Console.WriteLine("Enter String");
            string valueInputed = Console.ReadLine();
            int vowelCount = CountVowels(valueInputed);
            //count the value of  string in entered value
            Console.WriteLine($"Number of vowels in inputed string {vowelCount}");
        }
       
        public int CountVowels(string valueInputed)
        {
            //check my count of the stated value 
            int count = 0;
            foreach (char c  in valueInputed )
            {
                string vowelSounds = "aeiouAEIOU";
               if (vowelSounds.IndexOf(c) == -1)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
