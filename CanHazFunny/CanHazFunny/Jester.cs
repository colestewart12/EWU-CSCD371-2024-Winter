

using System;

namespace CanHazFunny;

public class Jester(IJokeOutput jokeOutput, IJokeService jokeService)
{
    private readonly IJokeService _jokeService = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
    private readonly IJokeOutput _jokeOutput = jokeOutput ?? throw new ArgumentNullException(nameof(jokeOutput));

    public void TellJoke()
    {
        string joke;
        do
        {
            joke = _jokeService.GetJoke();
        }while (joke.Contains("Chuck Norris"));

        _jokeOutput.WriteJoke(joke);
    }
}
