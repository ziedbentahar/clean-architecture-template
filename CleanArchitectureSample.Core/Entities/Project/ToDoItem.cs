using CleanArchitectureSample.Core.Entities.Project.Events;
using CleanArchitectureSample.SharedKernel;

namespace CleanArchitectureSample.Core.Entities.Project;

public class ToDoItem : EntityBase<int>
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsDone { get; private set; }

    public void MarkComplete()
    {
        if (!IsDone)
        {
            IsDone = true;

            RegisterDomainEvent(new ToDoItemCompletedEvent(this));
        }
    }

    public override string ToString()
    {
        string status = IsDone ? "Done!" : "Not done.";
        return $"{Id}: Status: {status} - {Title} - {Description}";
    }
}