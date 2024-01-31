namespace CanHazFunny;

public  sealed class Program
{
    public static void Main(string[] args)
    {

        new Jester(new JokeOutput(), new JokeService()).TellJoke();
    }
}
