using System;
using System.Linq;

namespace AOCDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fp = new FileParser<SlidingCounter>(@"/Users/filip/Documents/Playground/AdventOfCode2021/AOCDay1/input.txt");
            fp.Parsers.Add(new LineParser<SlidingCounter>((string s, SlidingCounter instance) =>
            {
                if (int.TryParse(s, out int i))
                {
                    instance.Values.Add(i);
                }
                return instance;
            }));

            int[] arr = fp.Parse().Values.ToArray();
            System.Console.WriteLine(GetIncrements(arr, arr.Length, 3));
            Console.ReadLine();
        }

        private static int GetIncrements(int[] arr, int count, int slideSize)
        {
            int col = 0, cnt = 0;
            while (col < count - slideSize)
            {
                int s1 = 0, s2 = 0;
                for (int i = 0; i < slideSize; i++)
                {
                    s1 += arr[col + i];
                    s2 += arr[col + i + 1];
                }
                if (s1 < s2)
                    cnt++;
                col++;
            }
            return cnt;
        }
    }
}
