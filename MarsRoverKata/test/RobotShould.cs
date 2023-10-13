using FluentAssertions;
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
        [Fact]
        public void Move_Forward()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.North);
            var remoteControl = new RemoteControl(robot);

            remoteControl.Execute("f");
            
            var state = new North(Direction.North, new Position(0, 1));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }

        [Fact]
        public void Move_Backwards()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.South);
            var remoteControl = new RemoteControl(robot);

            remoteControl.Execute("b");
            
            var state = new South(Direction.South, new Position(0, 1));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }

        [Fact]
        public void Rotate_Left()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.North);
            var remoteControl = new RemoteControl(robot);

            remoteControl.Execute("l");
            
            var state = new West(Direction.West, new Position(0, 0));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }
        
        [Fact]
        public void Rotate_Left2()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.South);
            var remoteControl = new RemoteControl(robot);

            remoteControl.Execute("l");
            
            var state = new East(Direction.East, new Position(0, 0));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }

        [Fact]
        public void Rotate_Right()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.North);
            var remoteControl = new RemoteControl(robot);

            remoteControl.Execute("r");
            
            var state = new East(Direction.East, new Position(0, 0));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }
        
        [Fact]
        public void Rotate_Right2()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.South);
            var remoteControl = new RemoteControl(robot);

            remoteControl.Execute("r");
            
            var state = new West(Direction.West, new Position(0, 0));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }

        [Fact]
        public void Rotate_Right_And_Move_Forward()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.North);
            var remoteControl = new RemoteControl(robot);
        
            remoteControl.Execute("rf");
            
            var state = new East(Direction.East, new Position(1, 0));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }
        
        [Fact]
        public void Rotate_Left_And_Move_Backward()
        {
            var initialPosition = new Position(0, 0);
            var robot = Robot.Create(initialPosition, Direction.North);
            var remoteControl = new RemoteControl(robot);
        
            remoteControl.Execute("lb");
        
            var state = new West(Direction.West, new Position(1, 0));
            remoteControl.GetRobotState().Should().BeEquivalentTo(state);
        }
    }
}