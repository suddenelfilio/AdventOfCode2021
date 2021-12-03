using System;

namespace AOCDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fp = new FileParser<IncrementCounter>(@"D:\Playground\AdventOfCode\AOCDay1\input.txt");
            fp.Parsers.Add(new LineParser<IncrementCounter>((string s, IncrementCounter instance) =>
            {
                if (int.TryParse(s, out int i))
                {
                    if (instance.PreviousValue.HasValue && i > instance.PreviousValue)
                    {
                        instance.NumberOfIncrements+=1;
                    }
                    instance.PreviousValue = i;

                }
                return instance;
            }));

            Console.WriteLine(fp.Parse().NumberOfIncrements);
            Console.ReadLine();
        }
    }
}
