namespace Builder
{
    internal class PlayerBuilder : IPlayerBuilder
    {
        private Player player = new Player();
        public void BuildPlayer() { player = new Player(); }

        public void WithName(string name)
        {
            player.Name = name;
            player.ShortName = name.Substring(0, 3).ToUpper();
        }

        public void WithPosition(PlayerPosition position)
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
        }

        public Player GetPlayer() { return player; }
    }
}
