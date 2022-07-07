using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public class ParamKeyword
    {
        // ll be return result
        public int result { get; }

        // result = param int[] numbers > goes on summarize method
        public ParamKeyword(params int[] numbers)
        {
            result = summarize(numbers);
        }

        public static int summarize(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
            }

            numbers = null;

            return total;
        }
    }
   
}
