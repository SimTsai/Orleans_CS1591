namespace Common.Models.HelloWorld;

/// <summary>
/// Greet Request
/// </summary>
[GenerateSerializer]
public partial record GreetRequestModel
{
    /// <summary>
    /// Name
    /// </summary>
    [Id(0)]
    public virtual string? Name { get; init; }
}
