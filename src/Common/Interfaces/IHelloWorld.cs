using Common.Models.HelloWorld;

namespace Common.Interfaces;

/// <summary>
/// Hello World
/// </summary>
public interface IHelloWorld : IGrainWithStringKey
{
    /// <summary>
    /// Say Greet
    /// </summary>
    Task<GreetReplyModel> SayGreetAsync(GreetRequestModel request);
}
