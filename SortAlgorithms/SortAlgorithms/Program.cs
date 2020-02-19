using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {

        public static void Main()
        {
            int[] nums = new int[] { 2, 4, 616, 7, 3, 68 };
           // Helper.insertionsort(nums);
            //DID SOme one ask him self for each or for loop is faster ? 
          //  for (int i = 0; i < nums.Length; i++)
         //   {
             //   Console.WriteLine(nums[i]);
          //  }
           // Console.WriteLine( Helper.PalindromComplex("TozqoT") );
            Console.WriteLine(Helper.Fibonnic(4));
            Console.WriteLine(Helper.Fibonnic2(4));
            Console.ReadKey();


        }

        //i don't remember what it's name :(
    }
}
