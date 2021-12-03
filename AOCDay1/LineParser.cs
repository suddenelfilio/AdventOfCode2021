using System;

namespace AOCDay1
{

    public class LineParser<T>
    {
        private readonly Func<string, T, T> processor;

        public LineParser(Func<string, T, T> processor)
        {
            this.processor = processor;
        }


        public T Process(T instance, string line)
        {
            return processor.Invoke(line, instance);
        }
    }
}