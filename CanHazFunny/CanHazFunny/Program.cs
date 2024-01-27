namespace CanHazFunny
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feel free to use your own setup here - this is just provided as an example
            //new Jester(new SomeReallyCoolOutputClass(), new SomeJokeServiceClass()).TellJoke();

            var OutputInstance = new JokeOutput();
            var ServiceInstance = new JokeService();

            new Jester(OutputInstance, ServiceInstance).TellJoke();
        }
    }
}
