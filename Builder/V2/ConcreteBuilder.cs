namespace Builder
{
    internal class PlayerBuilderV2 : IPlayerBuilderV2
    {
        private Player player = new Player();

        public PlayerBuilderV2() { player = new Player(); }

        public IPlayerBuilderV2 WithName(string name)
        {
            player.Name = name;
            player.ShortName = name.Substring(0, 3).ToUpper();
            return this;
        }

        public IPlayerBuilderV2 WithPosition(PlayerPosition position)
        {
            player.Position = position;
            if(position == PlayerPosition.Goalkeeper)
            {
                player.Line = "GK";
            } else if(position == PlayerPosition.CentralDefender || position == PlayerPosition.FullBack)
            {
                player.Line = "DF";
            } else if(position == PlayerPosition.AttackingMidfielder || position == PlayerPosition.DefensiveMidfielder)
            {
                player.Line = "MF";
            } else if(position == PlayerPosition.Striker || position == PlayerPosition.Winger)
            {
                player.Line = "FW";
            }
            return this;
        }

        public Player Build() { return player; }
    }
}
