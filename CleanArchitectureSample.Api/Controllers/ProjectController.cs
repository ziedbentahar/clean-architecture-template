using CleanArchitectureSample.Core.Services;
using CleanArchitectureSample.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSample.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectController : ControllerBase
{
    private readonly ILogger<ProjectController> _logger;
    private readonly IProjectService _projectService;

    public ProjectController(ILogger<ProjectController> logger, IProjectService projectService)
    {
        _logger = logger;
        _projectService = projectService;
    }

    [HttpGet(Name = "Get Project By Id")]
    public async Task<IActionResult> Get(int projectId)
    {
        var project = await _projectService.GetProjectById(projectId);

        if (project == null)
        {
            return NotFound();
        }
        return Ok(new ProjectDto
        {
            Name = project.Name,
            Id = project.Id
        });
    }
}