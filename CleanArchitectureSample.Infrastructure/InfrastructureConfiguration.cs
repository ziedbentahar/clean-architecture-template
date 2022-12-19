using CleanArchitectureSample.Core.Entities.Project;
using CleanArchitectureSample.Core.Interfaces;
using CleanArchitectureSample.Infrastructure.DataAccess;
using CleanArchitectureSample.Infrastructure.ThirdPartiesApis;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureSample.Infrastructure;

public static class InfrastructureConfiguration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection sc)
    {
        sc.AddSingleton<IProjectRepository, InMemoryProjectRepository>();
        sc.AddSingleton<IEmailSender, MailJetEmailProvider>();
        return sc;
    }
}