using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosineSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = "Hi All its All Binary"; //just make sure you put the longer string first  //then the second string comparing it with the first one
            var o2 = "Hi Binary";
            CosineSimilarity.Calculate(o, o2);
            Console.ReadKey();
        }
    }



    public class CosineSimilarity
    {
        public static void Calculate(string l1, string l2)
        {

            if (l1.Count() == 0 || l2.Count() == 0)
            {
                throw new Exception("Cosine Distance: lists cannot be zero length");
            }
            //first thing i will get the count of the words
            var l11 = l1.Split(' ').ToList(); // so this is vector now
            var l22 = l2.Split(' ').ToList();

            //now checking the exist of each word 
            Dictionary<String, int> L1Count = new Dictionary<string, int>();
            Dictionary<String, int> L2Count = new Dictionary<string, int>();

            foreach (var item in l11)
            {
                //put dictionary item for example =ahmed and return the count as the value
                L1Count[item] = l11.Count(e => e == item);
            }
            foreach (var item in l22)
            {
                //put dictionary item for example =ahmed and return the count as the value
                L2Count[item] = l11.Count(e => e == item);
            }

            //geting the count common word in both dicionary using the first directiory
            double dotproduct = 0;
            foreach (string token in l11)
            {//maybe occur error if you pass key that has no value
                if(L1Count.ContainsKey(token)  && L2Count.ContainsKey(token))
                {
                    if (L1Count[token] > 0 && L2Count[token] > 0)
                    {
                        //so now we get the first part which is Sum(A*B)
                        var tokenfreq = L1Count[token];
                        var tokenfreq2 = L2Count[token];
                        dotproduct += tokenfreq * tokenfreq2;
                    }
                }
               

            }
            //second part sqrt sum a^2 and sqart sum b^2
            //selecting the values of first dic and put them in list
            var flattenL1Values = L1Count.Select(e => e.Value).ToList();
            //selecting the values of second dic and put them in list
            var flattenL2Values = L2Count.Select(e => e.Value).ToList();

            //geting the sum of sqart error
            //the error i was doing e^2 it was xor i think 
            //testing
            var exq = flattenL1Values.Select(e => Math.Pow(e,2));  //Tricks math.pow is bad we could use e*e will improve the preformance
            var exqq = flattenL2Values.Select(e => Math.Pow(e, 2));
            var exqsum = flattenL1Values.Select(e => Math.Pow(e, 2)).Sum();
            var exqqsum = flattenL2Values.Select(e => Math.Pow(e, 2)).Sum();
            var exqsumsq = Math.Sqrt(exqsum);
            var exqqsumsq = Math.Sqrt(exqqsum);
            //////
            
            var sqrtsuma = Math.Sqrt(flattenL1Values.Select(e => Math.Pow(e, 2)).Sum());
           var sqrtsumb= Math.Sqrt(flattenL2Values.Select(e => Math.Pow(e, 2)).Sum());

            double Cos = dotproduct / (sqrtsuma * sqrtsumb);
            // convert cosine value to radians then to degrees
            Console.WriteLine("Cos Value in Radians = "+Cos);
           var ex= Math.Acos(Cos) * 180.0 / Math.PI;
            Console.WriteLine("Cos Value in Degree  = " + ex); 
          
        }
    }
}
