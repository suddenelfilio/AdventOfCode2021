using System;

namespace AOCDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fp = new FileParser<AimedCoordinates>(@"D:\Playground\AdventOfCode\Day 2\AOCDay2\input.txt");
            fp.Parsers.Add(new LineParser<AimedCoordinates>((string s, AimedCoordinates instance) =>
            {

                var parts = s.Trim().Split(" ");
                if (parts.Length == 2 && parts[0].Equals("forward", StringComparison.OrdinalIgnoreCase))
                {
                    if (int.TryParse(parts[1], out int i))
                        instance.Horizontal += i;
                    instance.Depth += (instance.Aim * i);

                }

                return instance;
            }));
            fp.Parsers.Add(new LineParser<AimedCoordinates>((string s, AimedCoordinates instance) =>
            {

                var parts = s.Trim().Split(" ");
                if (parts.Length == 2)
                {
                    if (int.TryParse(parts[1], out int i))
                    {
                        switch (parts[0])
                        {
                            case "up":
                                instance.Aim -= i;
                                break;
                            case "down":
                                instance.Aim += i;
                                break;
                        }
                    }
                }

                return instance;
            }));
            Console.WriteLine(fp.Parse().EndResult);
            Console.ReadLine();
        }
    }
}
