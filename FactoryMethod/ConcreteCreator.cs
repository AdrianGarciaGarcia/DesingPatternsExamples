namespace FactoryMethod
{
    public class LocalTeamCreator : TeamCreator
    {
        public override IEnumerable<IPlayer> CreateTeam()
        {
            for(int i = 0; i < 4; i++)
            {
                yield return new Defender();
            }
        }
    }

    public class AwayTeamCreator : TeamCreator
    {
        public override IEnumerable<IPlayer> CreateTeam()
        {
            for(int i = 0; i < 3; i++)
            {
                yield return new PressuredDefender();
            }
        }
    }
}
