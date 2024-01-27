namespace CanHazFunny;

public class Program
{
    public static void Main(string[] args)
    {

        var OutputInstance = new JokeOutput();
        var ServiceInstance = new JokeService();

        new Jester(OutputInstance, ServiceInstance).TellJoke();
    }
}
