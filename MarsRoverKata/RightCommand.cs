namespace MarsRoverKata
{
    public class RightCommand : Command
    {
        public RightCommand(Robot robot) : base(robot)
        {
        }

        public override void Execute()
        {
            Robot.TurnRight();
        }
    }
}