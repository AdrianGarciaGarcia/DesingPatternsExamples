namespace FactoryMethod
{
    public abstract class TeamCreator
    {
        public abstract IEnumerable<IPlayer> CreateTeam();
    }
}
