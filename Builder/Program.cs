
using Builder;

Console.WriteLine("Start Builder");

var builder = new PlayerBuilder();

builder.BuildPlayer();
builder.WithName("Jan Jenkins");
builder.WithPosition(PlayerPosition.FullBack);

var player = builder.GetPlayer();
Console.WriteLine(player.ToString());

builder.BuildPlayer();
builder.WithName("Larry Jenkins");
builder.WithPosition(PlayerPosition.Striker);

var player2 = builder.GetPlayer();
Console.WriteLine(player2.ToString());

Console.WriteLine("Start Builder V2");

var builderV2 = new PlayerBuilderV2();
var player3 = builderV2.WithName("Tobias Max").WithPosition(PlayerPosition.CentralDefender).Build();
Console.WriteLine(player3.ToString());

