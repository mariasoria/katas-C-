namespace MarsRoverKata
{
    public abstract class Command
    {
        protected readonly Robot Robot;

        protected Command(Robot robot)
        {
            Robot = robot;
        }

        public abstract void Execute();
    }
}