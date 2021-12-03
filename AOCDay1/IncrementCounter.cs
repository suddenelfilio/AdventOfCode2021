namespace AOCDay1
{
    public class IncrementCounter
    {

        public int NumberOfIncrements { get; set; } = 0;
        public int? PreviousValue { get; set; } = null;

        public override string ToString()
        {
            return $"prev: {PreviousValue} - Incr: {NumberOfIncrements}";
        }
    }
}