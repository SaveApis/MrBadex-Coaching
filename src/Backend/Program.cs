using System.Reflection;
using SaveApis.Core.Application.Jwt;
using SaveApis.Core.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.WithAssemblies(Assembly.GetExecutingAssembly()).AddSaveApis(executorBuilder => executorBuilder.DisableIntrospection(false), AuthenticationMode.JwtWithSso);

var app = builder.Build();

await app.RunSaveApisAsync(args).ConfigureAwait(false);
