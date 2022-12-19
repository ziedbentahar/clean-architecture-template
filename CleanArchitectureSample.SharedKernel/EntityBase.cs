namespace CleanArchitectureSample.SharedKernel;

public abstract class EntityBase<TId>
{
    public TId Id { get; set; }

    private readonly List<DomainEventBase> _domainEvents = new ();
  
    public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

    protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
    internal void ClearDomainEvents() => _domainEvents.Clear();
}
