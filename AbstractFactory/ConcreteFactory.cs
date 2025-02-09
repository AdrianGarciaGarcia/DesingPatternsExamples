namespace AbstractFactory
{
    public class LocalTeam : TeamFactory
    {
        public IPlayer CreateGoalkeeper() { return new Goalkeeper(); }
        public IPlayer CreateDefender() { return new Defender(); }
        public IPlayer CreateMidfielder() { return new Midfielder(); }
        public IPlayer CreateForward() { return new Forward(); }
    }

    public class AwayTeam : TeamFactory
    {
        public IPlayer CreateGoalkeeper() { return new Goalkeeper(); }
        public IPlayer CreateDefender() { return new PressuredDefender(); }
        public IPlayer CreateMidfielder() { return new Midfielder(); }
        public IPlayer CreateForward() { return new Forward(); }
    }
}
