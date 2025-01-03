namespace AbstractFactory
{
    public interface IGoalkeeper
    {
        public void Pass();

        public void Shoot();
    }

    public interface IDefender
    {
        public void Pass();

        public void Shoot();
    }

    public interface IMidfielder
    {
        public void Pass();

        public void Shoot();
    }

    public interface IForward
    {
        public void Pass();

        public void Shoot();
    }
}
