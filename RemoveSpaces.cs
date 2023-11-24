using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpChallenge
{
    public  class RemoveSpaces
    {
     
        public void removeSpaces()
        {
            int[] orignA = { 1, 2, 0, 0, 4 };
            Console.WriteLine(orignA);

            //removing spaces - am using LINQ FOR QUERY
            int[] removedArraySpaces = orignA.Where(item => item != 0).ToArray();

            Console.WriteLine(removedArraySpaces);
            Console.WriteLine(string.Join(", ", removedArraySpaces));
            //joins the brackets so that it can be an array
            Console.Write("[ ");
            Console.Write(string.Join(", ", removedArraySpaces));
            Console.WriteLine(" ]");

        }

    }
}
