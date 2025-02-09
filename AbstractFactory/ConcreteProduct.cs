namespace AbstractFactory
{
    public class Goalkeeper : IPlayer
    {
        public void Pass() { Console.WriteLine("Goalkeeper passes the ball"); }
        public void Shoot() { Console.WriteLine("Goalkeeper cannot shoot"); }
    }

    public class Defender() : IPlayer
    {
        public void Pass() { Console.WriteLine("Defender passes the ball"); }
        public void Shoot() { Console.WriteLine("Defender shoots the ball"); }
    }

    public class PressuredDefender() : IPlayer
    {
        public void Pass() { Console.WriteLine("Defender passes the ball with the pressure of the public"); }
        public void Shoot() { Console.WriteLine("Defender shoots the ball with the pressure of the public"); }
    }


    public class Midfielder : IPlayer
    {
        public void Pass() { Console.WriteLine("Midfielder passes the ball"); }
        public void Shoot() { Console.WriteLine("Midfielder shoots the ball"); }
    }

    public class Forward : IPlayer
    {
        public void Pass() { Console.WriteLine("Forward passes the ball"); }
        public void Shoot() { Console.WriteLine("Forward shoots the ball"); }
    }
}
