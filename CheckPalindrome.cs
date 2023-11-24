using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpChallenge
{
    public class CheckPalindrome
    {
        public string checkEnteredValue()
        {
            Console.WriteLine("Enter value to check palindrome");
            string s = Console.ReadLine();
            char[] singleChar = s.ToCharArray();
            //Have reversed value
            Array.Reverse(singleChar);
            string newString = new string(singleChar);
            Console.WriteLine(newString,s);
            return s == newString ? "Value is a palindrome" : "value is not a palindrome";
        }
    }
}
