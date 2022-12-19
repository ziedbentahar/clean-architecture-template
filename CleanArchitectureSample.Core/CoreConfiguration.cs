using CleanArchitectureSample.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureSample.Core;

public static class CoreConfiguration
{
    public static IServiceCollection AddCore(this IServiceCollection sc)
    {
        sc.AddSingleton<IProjectService, ProjectService>();
        return sc;
    }
}