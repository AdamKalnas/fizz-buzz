using System.Collections.Generic;

namespace fizzbuzz
{
    public class FizzBuzz
    {
        public List<string> Play(int start, int finish)
        {
            var output = new List<string>();
            if (finish <= start)
            {
                return output;
            }
          
            for (int i = start; i < finish + 1; i++)
            {               
                if (ShouldFizzBuzz(i))
                {
                    output.Add("FizzBuzz");
                    continue;
                }
                if (ShouldFizz(i))
                {
                    output.Add("Fizz");
                    continue;
                }
                if (ShouldBuzz(i))
                {
                    output.Add("Buzz");
                    continue;
                }
                output.Add(i.ToString());
            }
            return output;
        }

        private static bool ShouldFizzBuzz(int i)
        {
            return ShouldFizz(i) && ShouldBuzz(i);
        }

        private static bool ShouldBuzz(int i)
        {
            return i % 5 == 0 || i.ToString().Contains("5");
        }

        private static bool ShouldFizz(int i)
        {
            return i%3 == 0 || i.ToString().Contains("3");
        }
    }
}
