namespace CleanArchitectureSample.SharedKernel;

public abstract class DomainEventBase
{
    public DateTime EventDate { get; protected set; } = DateTime.UtcNow;
}