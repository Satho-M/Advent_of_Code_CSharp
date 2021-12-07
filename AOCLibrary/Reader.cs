    namespace Advent_of_Code_Library
    {
        public class Reader
        {
            public IEnumerable<string> ReadInput(string input)
            {
                string[] output = File.ReadAllLines(@"..\..\..\" + input);

                return output;
            }

            public IEnumerable<string> CleanSpaces(IEnumerable<string> input)
            {
                IEnumerable<string> output = input.Where(l => !String.IsNullOrEmpty(l)).ToList();

                return output;
            }
        }
    }