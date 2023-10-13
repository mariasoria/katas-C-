namespace MarsRoverKata
{
    public abstract class Command
    {
        protected readonly Robot robot;

        protected Command(Robot robot)
        {
            this.robot = robot;
        }

        public abstract void Execute();
    }

    public class ForwardCommand : Command
    {
        public ForwardCommand(Robot robot) : base(robot)
        {
        }

        public override void Execute()
        {
            robot.MoveForward();
        }
    }

    public class BackwardCommand : Command
    {
        public BackwardCommand(Robot robot) : base(robot)
        {
        }

        public override void Execute()
        {
            robot.MoveBackwards();
        }
    }

    public class LeftCommand : Command
    {
        public LeftCommand(Robot robot) : base(robot)
        {
        }

        public override void Execute()
        {
            robot.TurnLeft();
        }
    }

    public class RightCommand : Command
    {
        public RightCommand(Robot robot) : base(robot)
        {
        }

        public override void Execute()
        {
            robot.TurnRight();
        }
    }
}