using CleanArchitectureSample.Core.Entities.Project;

namespace CleanArchitectureSample.Core.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    
    public async Task<Project> CreateNewProject(string name)
    {
        var project = new Project(name, PriorityStatus.Backlog);
        var createdProject = await _projectRepository.CreateNewProject(project);

        return createdProject;
    }

    public async Task<Project> GetProjectById(int projectId)
    {
        return await _projectRepository.GetProjectById(projectId);
    }

    public async Task AssignNewItemToProject(int projectId, string itemTitle, string itemDescription)
    {
        // some validation logic could be added here
        
        var project = await _projectRepository.GetProjectById(projectId);
        project.AddItem(new ToDoItem { Description = itemDescription, Title = itemTitle});

        await _projectRepository.UpdateProject(project);
        
    }
}