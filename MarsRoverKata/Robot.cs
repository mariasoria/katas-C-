using System;
using FluentAssertions;

namespace MarsRoverKata
{
    public class Robot
    {
        public Position Position { get; private set; }
        public Direction Direction { get; private set; }
        
        public Robot(Position initialPosition, Direction direction)
        {
            Position = initialPosition;
            Direction = direction;
        }

        public void Execute(string commands)
        {
            var commandy = commands.ToCharArray();
            foreach (var c in commandy)
            {
                var command = Commands.From(c, this);
                switch (command)
                {
                    case ForwardCommand:
                        MoveForward();
                        break;
                    case BackwardCommand:
                        MoveBackwards();
                        break;
                    case LeftCommand:
                        TurnLeft();
                        break;
                    default:
                        TurnRight();
                        break;
                }
            }
        }
        
        public void TurnRight()
        {
            Direction = Direction.East;
        }

        public void TurnLeft()
        {
            Direction = Direction.West;
        }

        public void MoveBackwards()
        {
            // maybe this is responsibility of the state (North, South...) to increment or decrement position/orientation 
            // this way we can use the state pattern as well
            // and strategy pattern???
            // check where it is facing and the move
            if (Direction == Direction.East)
            {
                // move east
                Position = new Position(-1, 0);
            } else if (Direction == Direction.West)
            {
                Position = new Position(1, 0);
            } else if (Direction == Direction.North)
            {
                Position = new Position(0, -1);
            } else 
            {
                Position = new Position(0, 1);
            }
        }

        public void MoveForward()
        {
            // check where it is facing and the move
            // Position = new Position(0, 1);
            if (Direction == Direction.East)
            {
                // move east
                Position = new Position(1, 0);
            } else if (Direction == Direction.West)
            {
                Position = new Position(-1, 0);
            } else if (Direction == Direction.North)
            {
                Position = new Position(0, 1);
            } else 
            {
                Position = new Position(0, -1);
            }
            
            
        }
    }
    
}

