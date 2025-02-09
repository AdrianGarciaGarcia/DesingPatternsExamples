using FactoryMethod;

var localPlayers = new LocalTeamCreator().CreateTeam();

Console.WriteLine("There are {0} local players", localPlayers.Count());

var awayPlayers = new AwayTeamCreator().CreateTeam();

Console.WriteLine("There are {0} away players", awayPlayers.Count());


Console.WriteLine("Press any key to exit...");
Console.ReadKey();