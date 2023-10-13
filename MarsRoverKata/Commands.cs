using System;

namespace MarsRoverKata
{
    public class Commands
    {
        public static Command From(char c, Robot robot)
        {
            var command = (Command)(c.ToString() switch
            {
                "f" => new ForwardCommand(robot),
                "b" => new BackwardCommand(robot),
                "l" => new LeftCommand(robot),
                "r" => new RightCommand(robot),
                _ => throw new ArgumentException($"Unknown command {c.ToString()}")
            });
            return command;
        }
    }
}