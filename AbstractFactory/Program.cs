using AbstractFactory;

Console.WriteLine("Create local team");

var localTeam = new LocalTeam();

var localGoalkeeper = localTeam.CreateGoalkeeper();
var localDefender = localTeam.CreateDefender();
var localMidfielder = localTeam.CreateMidfielder();
var localForward = localTeam.CreateForward();


Console.WriteLine("Create away team");

var awayTeam = new AwayTeam();

var awayGoalkeeper = awayTeam.CreateGoalkeeper();
var awayDefender = awayTeam.CreateDefender();
var awayMidfielder = awayTeam.CreateMidfielder();
var awayForward = awayTeam.CreateForward();


Console.WriteLine("Ball goes to the local defender");
localDefender.Pass();

Console.WriteLine("Ball goes to the away defender");
awayDefender.Pass();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
