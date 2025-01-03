namespace AbstractFactory
{
    public class LocalTeam : TeamFactory
    {
        public IGoalkeeper CreateGoalkeeper() { return new Goalkeeper(); }
        public IDefender CreateDefender() { return new Defender(); }
        public IMidfielder CreateMidfielder() { return new Midfielder(); }
        public IForward CreateForward() { return new Forward(); }
    }

    public class AwayTeam : TeamFactory
    {
        public IGoalkeeper CreateGoalkeeper() { return new Goalkeeper(); }
        public IDefender CreateDefender() { return new PressuredDefender(); }
        public IMidfielder CreateMidfielder() { return new Midfielder(); }
        public IForward CreateForward() { return new Forward(); }
    }
}
