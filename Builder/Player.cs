namespace Builder
{
    public class Player
    {
        public string Name { get; set; } = "No name";

        public string ShortName { get; set; } = "NaN";

        public PlayerPosition Position { get; set; }

        public string Line { get; set; } = "No line";

        public override string ToString() { return $"{Name} ({ShortName}) - {Position} - {Line}"; }
    }
}
