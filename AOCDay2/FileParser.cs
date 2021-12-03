using System;
using System.Collections.Generic;
using System.IO;

namespace AOCDay2
{
    public class FileParser<T>
    {
        public FileParser(string file)
        {
            File = file;
        }

        public string File { get; }

        public List<LineParser<T>> Parsers { get; init; } = new List<LineParser<T>>();

        public T Parse()
        {
            T result = Activator.CreateInstance<T>();
            using (var fs = new FileStream(File, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (var parser in Parsers)
                        {

                            result = parser.Process(result, line);
                        }
                    }
                }
            }

            return result;
        }
    }
}