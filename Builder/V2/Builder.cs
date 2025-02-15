namespace Builder
{
    public interface IPlayerBuilderV2
    {
        IPlayerBuilderV2 WithName(string name);

        IPlayerBuilderV2 WithPosition(PlayerPosition position);

        Player Build();
    }
}
