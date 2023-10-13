﻿using FluentAssertions;
using Xunit;

namespace MarsRoverKata.test
{
    // Try to parametrise test by functionality
    // Move forward (facing south, facing north...)
    // Move backwards (facing south, facing north...)
    // Turn left (facing south, facing north...)
    // turn right (facing south, facing north...)
    public class RobotShould
    {
    /*
 * You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W)
 * it is facing.
   The rover receives a character array of commands.
   Implement commands that move the rover forward/backward (f,b).
   Implement commands that turn the rover left/right (l,r).
   Implement wrapping at edges. But be careful, planets are spheres.
   Implement obstacle detection before each move to a new square. 
        If a given sequence of commands encounters an obstacle, 
        the rover moves up to the last possible point, 
        aborts the sequence and reports the obstacle.
 */

        [Fact]
        public void Move_Forward()
        {
            var initialPosition = new Position(0, 0);
            var robot = new Robot(initialPosition, Direction.North);

            robot.Execute("f");

            robot.Position.X.Should().Be(0);
            robot.Position.Y.Should().Be(1);
        }

        [Fact]
        public void Move_Backwards()
        {
            ;
            var initialPosition = new Position(0, 1);
            var robot = new Robot(initialPosition, Direction.South);

            robot.Execute("b");

            robot.Position.X.Should().Be(0);
            robot.Position.Y.Should().Be(1);
        }

        [Fact]
        public void Rotate_Left()
        {
            var initialPosition = new Position(0, 0);
            var robot = new Robot(initialPosition, Direction.North);

            robot.Execute("l");

            robot.Direction.Should().Be(Direction.West);
            robot.Position.X.Should().Be(0);
            robot.Position.Y.Should().Be(0);
        }

        [Fact]
        public void Rotate_Right()
        {
            var initialPosition = new Position(0, 0);
            var robot = new Robot(initialPosition, Direction.North);

            robot.Execute("r");

            robot.Direction.Should().Be(Direction.East);
            robot.Position.X.Should().Be(0);
            robot.Position.Y.Should().Be(0);
        }

        [Fact]
        public void Rotate_Right_And_Move_Forward()
        {
            var initialPosition = new Position(0, 0);
            var robot = new Robot(initialPosition, Direction.North);

            robot.Execute("rf");

            robot.Direction.Should().Be(Direction.East);
            robot.Position.X.Should().Be(1);
            robot.Position.Y.Should().Be(0);
        }
        
        [Fact]
        public void Rotate_Left_And_Move_Backward()
        {
            var initialPosition = new Position(0, 0);
            var robot = new Robot(initialPosition, Direction.North);

            robot.Execute("lb");

            robot.Direction.Should().Be(Direction.West);
            robot.Position.X.Should().Be(1);
            robot.Position.Y.Should().Be(0);
        }
    }
}