namespace MarsRoverKata
{
    public class Robot
    {
        public Position Position { get; private set; }
        public Direction Direction { get; private set; }
        
        public State State { get; private set; }

        public Robot(Position initialPosition, Direction direction)
        {
            Position = initialPosition;
            Direction = direction;
            State = CreateState();
        }
        
        // ToDo. Make constructor private and do all the calls to the FactoryMethod
        private State CreateState()
        {
            if (Direction == Direction.South)
            {
                return new South(Direction, Position);
            }
            if (Direction == Direction.North)
            {
                return new North(Direction, Position);
            }
            return new North(Direction, Position);
        }

        public void TurnRight()
        {
            Direction = Direction.East;
            State = State.TurnRight();
        }

        public void TurnLeft()
        {
            Direction = Direction.West;
            State = State.TurnLeft();
        }

        public void MoveBackwards()
        {
            State = State.MoveBackwards();
        }

        public void MoveForward()
        {
            State = State.MoveForward();
        }
    }
    
}

