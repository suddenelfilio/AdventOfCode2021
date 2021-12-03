namespace AOCDay2
{
    public class Coordinates
    {
        public int Horizontal { get; set; }
        public int Depth { get; set; }

        public virtual int EndResult => Horizontal * Depth;
    }

    public class AimedCoordinates: Coordinates
    {

        public int Aim { get; set; } = 0;

        public override int EndResult => Horizontal * Depth;
    }
}
