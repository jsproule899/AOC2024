
using System.Net;
using AOC;

namespace AOC
{
    static class Day1
    {
        static List<int> left = new List<int>();
        static List<int> right = new List<int>();

        public static void partOne()
        {

            string[] lines = File.ReadLines(Path.Join(@"C:\Users\joshs\Dev\AOC\2024\Day1\input.txt")).ToArray();
            int sum = 0;

            foreach (var line in lines)
            {
                string[] nums = line.Split("   ");
                left.Add(int.Parse(nums[0]));
                right.Add(int.Parse(nums[1]));
            }

            left.Sort();
            right.Sort();

            for (int i = 0; i < right.Count; i++)
            {
                sum += Math.Abs(right[i] - left[i]);
            }

            Console.WriteLine("Total: " + sum);
        }

        public static void partTwo()
        {
            int sim = 0;
            foreach (int num in left)
            {
                int freq = 0;
                foreach (int num2 in right)
                {
                    if (num2 == num)
                    {
                        freq++;
                    }
                }
                sim += num * freq;

            }

            Console.WriteLine("similiarity: " + sim);
        }
    }


}

