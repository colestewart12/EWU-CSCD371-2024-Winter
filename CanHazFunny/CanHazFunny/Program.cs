namespace CanHazFunny
{
    class Program
    {
        static void Main(string[] args)
        {

            var OutputInstance = new JokeOutput();
            var ServiceInstance = new JokeService();

            new Jester(OutputInstance, ServiceInstance).TellJoke();
        }
    }
}
