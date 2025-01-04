namespace Builder
{
    public interface IPlayerBuilder
    {
        void BuildPlayer();

        void WithName(string name);

        void WithPosition(PlayerPosition position);

        Player GetPlayer();
    }
}
