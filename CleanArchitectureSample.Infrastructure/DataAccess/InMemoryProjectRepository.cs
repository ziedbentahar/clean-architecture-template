using CleanArchitectureSample.Core.Entities.Project;

namespace CleanArchitectureSample.Infrastructure.DataAccess;



public class InMemoryProjectRepository : IProjectRepository
{
    private static int _currentId = 0; 
    private readonly IList<Project> _projects = new List<Project>();
    
    public async Task<Project> GetProjectById(int id)
    {
        return  _projects.FirstOrDefault(item => item.Id == id);
    }

    public async Task UpdateProject(Project project)
    {
        throw new NotImplementedException();
    }

    public async Task<Project> CreateNewProject(Project project)
    {
        project.Id = ++_currentId;
        _projects.Add(project);

        return project;
    }
}