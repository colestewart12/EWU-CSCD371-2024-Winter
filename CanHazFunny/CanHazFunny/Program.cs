namespace CanHazFunny;

public  sealed class Program
{
    public static void Main(string[] args)
    {

        var OutputInstance = new JokeOutput();
        var ServiceInstance = new JokeService();
new Jester(new JokeOutput(), new JokeService()).TellJoke();
        new Jester(OutputInstance, ServiceInstance).TellJoke();
    }
}
