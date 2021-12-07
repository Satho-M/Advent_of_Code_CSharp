using Advent_of_Code_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01
{
    class Solutions
    {
        Reader reader = new Reader();

        //Converts to Int
        IEnumerable<int> Numbers(IEnumerable<string> input) => input.Select(s => int.Parse(s));

        public int DepthIncrease()
        {
            int depthIncreases = 0;
            List<int> numbers = Numbers(reader.ReadInput("input.in")).ToList();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if(numbers[i] < numbers[i + 1])
                {
                   depthIncreases++;
                }
            }

            return depthIncreases;
        }

        public int SumThreeDepths()
        {
            int group = 0, tmp = 0, sum = 0;

            List<int> numbers = Numbers(reader.ReadInput("input.in")).ToList();
            for(int i = 0; i < numbers.Count; i++)
            {
                if (i + 2 < numbers.Count)
                {
                    if (group != 0)
                    {
                        tmp = numbers[i] + numbers[i + 1] + numbers[i + 2];
                        if (tmp > group)
                        {
                            sum++;
                        }
                        group = tmp;
                    }
                    group = numbers[i] + numbers[i + 1] + numbers[i + 2];
                }
                else
                    break;
            }

            return sum;
        }
    }
}
