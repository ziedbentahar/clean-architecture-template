using CleanArchitectureSample.Core.Entities.Project;

namespace CleanArchitectureSample.Core.Services;

public interface IProjectService
{
    Task<Project> CreateNewProject(string name);
    Task AssignNewItemToProject(int projectId, string itemTitle, string itemDescription);

    Task<Project> GetProjectById(int projectId);
}