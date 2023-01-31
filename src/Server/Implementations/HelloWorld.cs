using Common.Interfaces;
using Common.Models.HelloWorld;

namespace Server.Implementations;

internal class HelloWorld : Grain, IHelloWorld
{
    async public Task<GreetReplyModel> SayGreetAsync(GreetRequestModel request)
    {
        await Task.CompletedTask;
        return new() { Message = $"Hello ${request.Name}." };
    }
}
