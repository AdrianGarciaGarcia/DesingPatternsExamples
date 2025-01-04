
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

