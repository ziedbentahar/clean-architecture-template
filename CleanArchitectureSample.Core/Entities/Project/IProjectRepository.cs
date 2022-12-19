namespace CleanArchitectureSample.Core.Entities.Project;

public interface IProjectRepository
{
    Task<Project> GetProjectById(int i);
    Task UpdateProject(Project project);
    Task<Project> CreateNewProject(Project project);
}