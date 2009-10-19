using System.Collections.Generic;
using CodeTime.Domain.Projects;
using CodeTime.OpenRasta.Service.DependencyInjection;
using CodeTime.OpenRasta.Service.Handlers;
using OpenRasta;
using OpenRasta.Configuration;
using OpenRasta.Configuration.Fluent;

namespace CodeTime.OpenRasta.Service
{
    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            var host = new AspNetHost();
            host.DependencyResolverAccessor = new WindsorResolverFactory();

            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has.ResourcesOfType<IEnumerable<Project>>()
                    .AtUri("/projects")
                    .HandledBy<ProjectsHandler>()
                    .AsXmlDataContract();
            }
        }
    }
}