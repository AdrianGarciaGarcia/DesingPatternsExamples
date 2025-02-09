namespace AbstractFactory
{
    public interface TeamFactory
    {
        public IPlayer CreateGoalkeeper();

        public IPlayer CreateDefender();

        public IPlayer CreateMidfielder();

        public IPlayer CreateForward();
    }
}
