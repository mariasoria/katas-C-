namespace MarsRoverKata
{
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public Position Increment()
        {
            return new Position(X, Y + 1);
        }

        public Position Decrement()
        {
            return new Position(X, Y - 1);
        }
    }
}