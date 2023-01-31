namespace Common.Models.HelloWorld;

/// <summary>
/// Greet Reply
/// </summary>
[GenerateSerializer]
public partial record GreetReplyModel
{
    /// <summary>
    /// Message
    /// </summary>
    [Id(0)]
    public virtual string? Message { get; init; }
}
