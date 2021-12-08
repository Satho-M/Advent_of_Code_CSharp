using Advent_of_Code_Library;

namespace Day02
{
    internal class Solutions
    {
        Reader reader = new Reader();

        public int HorizontalPositionAndDepth()
        {
            int depth = 0, horizontal = 0, units;
            string direction;

            IEnumerable<string> input = reader.ReadInput("input.in");
            foreach (string s in input)
            {
                direction = s.Split(' ')[0];
                units = Int32.Parse(s.Split(' ')[1]);

                switch (direction)
                {
                    case "forward":
                        horizontal += units;
                        break;
                    case "down":
                        depth += units;
                        break;
                    case "up":
                        depth -= units;
                        break;
                    default:
                        break;
                }
            }

            return depth * horizontal;

        }

        public int WithAim()
        {
            int depth = 0, horizontal = 0, units, aim = 0;
            string direction;

            IEnumerable<string> input = reader.ReadInput("input.in");
            foreach (string s in input)
            {
                direction = s.Split(' ')[0];
                units = Int32.Parse(s.Split(' ')[1]);

                switch (direction)
                {
                    case "forward":
                        horizontal += units;
                        depth += (aim * units);
                        break;
                    case "down":
                        aim += units;
                        break;
                    case "up":
                        aim -= units;
                        break;
                    default:
                        break;
                }
            }

            return depth * horizontal;
        }





    }
}
