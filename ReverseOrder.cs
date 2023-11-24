using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpChallenge
{
    public class ReverseOrder
    {
        //USER ENTER 
        public int userEnterInputs()
        {
            int n = 0;
            int reverseNum = 0;
            Console.WriteLine("Enter Number to Reverse");
            string  valueOne = Console.ReadLine();
           //Convert String to Integer  and check if value is int if not call again
           if(int.TryParse(valueOne, out n))
            {
                Console.WriteLine($"Entered Value is {n}");
                while( n != 0)
                {
                  int  dgt = n % 10;
                 reverseNum = reverseNum * 10 + dgt;
                    n  = n / 10;
                }
            }
            else
            {
                Console.WriteLine("Value is not an integer");
            }
            return reverseNum;
        }
    }
}
