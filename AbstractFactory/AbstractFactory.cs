namespace AbstractFactory
{
    public interface TeamFactory
    {
        public IGoalkeeper CreateGoalkeeper();

        public IDefender CreateDefender();

        public IMidfielder CreateMidfielder();

        public IForward CreateForward();
    }
}
