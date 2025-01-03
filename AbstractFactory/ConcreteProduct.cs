namespace AbstractFactory
{
    public class Goalkeeper : IGoalkeeper
    {
        public void Pass() { Console.WriteLine("Goalkeeper passes the ball"); }
        public void Shoot() { Console.WriteLine("Goalkeeper cannot shoot"); }
    }

    public class Defender() : IDefender
    {
        public void Pass() { Console.WriteLine("Defender passes the ball"); }
        public void Shoot() { Console.WriteLine("Defender shoots the ball"); }
    }

    public class PressuredDefender() : IDefender
    {
        public void Pass() { Console.WriteLine("Defender passes the ball with the pressure of the public"); }
        public void Shoot() { Console.WriteLine("Defender shoots the ball with the pressure of the public"); }
    }


    public class Midfielder : IMidfielder
    {
        public void Pass() { Console.WriteLine("Midfielder passes the ball"); }
        public void Shoot() { Console.WriteLine("Midfielder shoots the ball"); }
    }

    public class Forward : IForward
    {
        public void Pass() { Console.WriteLine("Forward passes the ball"); }
        public void Shoot() { Console.WriteLine("Forward shoots the ball"); }
    }
}
