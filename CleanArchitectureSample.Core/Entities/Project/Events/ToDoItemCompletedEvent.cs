using CleanArchitectureSample.SharedKernel;

namespace CleanArchitectureSample.Core.Entities.Project.Events;

public class ToDoItemCompletedEvent : DomainEventBase
{
    public ToDoItem CompletedItem { get; set; }

    public ToDoItemCompletedEvent(ToDoItem completedItem)
    {
        CompletedItem = completedItem;
    }
}