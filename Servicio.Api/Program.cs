using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Servicio.Api.Configuration.Autofact;
using Servicio.Api.Extensions;
using Servicio.Application.DTOs;
using Servicio.Infrestructure;
using Shared.Common;
using Steeltoe.Extensions.Configuration.ConfigServer;
using System.Reflection;
using Servicio.Infrestructure.Extensions;
using Microsoft.AspNetCore.OData;
using Servicio.Api.Configuration.OData;

Principal(args);



static void Principal(string[] args)
{
    var ns = typeof(Program).Namespace;
    var appName = string.Empty;
    ObtenerConfiguracion(out var configuration);
    if (ns != null)
    {
        appName = ns.Split('.')[0];
    }
    Log.Logger = LoggerCreator.CreateSerilogLogger(configuration, appName);
    Log.Information("Applicación Inicializada");

    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();

    var appSettings = new AppSettings();
    configuration.Bind(appSettings);

    builder.Services.Configure<AppSettings>(configuration);

    builder.Services.AddDbContext<BosniContextDb>(options =>
    {
        options.UseSqlServer(appSettings.ConnectionStrings.Default);
    });

    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
    });

    builder.Services.AddHttpContextAccessor();

    builder.Services.AddControllers(options => options.EnableEndpointRouting = false).AddOData(options =>
    options.Select().Expand().Filter().OrderBy().SetMaxTop(null).SkipToken().Count());

    builder.Services.AddApiVersioningExtension();

    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Production")
    {
        ConfiguracionSwagger(builder.Services);
    }

    builder.Host.UseSerilog();

    builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

    builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
    {
        ConfigureContainer(builder);
    });

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseAuthorization();

    app.UseErrorHandlingMiddleware();

    app.MapControllers();

    app.UseCors("AllowAll");

    app.Run();

}



static void ObtenerConfiguracion(out IConfiguration configuration)
{
    var directoryPath = AppDomain.CurrentDomain.BaseDirectory;
    configuration = new ConfigurationBuilder()
        .SetBasePath(directoryPath)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
        .AddEnvironmentVariables()
        .AddConfigServer()
        .Build();
}

static void ConfiguracionSwagger(IServiceCollection services)
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    services.AddSwaggerGen(options =>
    {
        options.OperationFilter<ODataQueryOptionsFilter>();
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "Servicios CENACE",
            Description = "API que expone informacion desde BOSNI",
        });
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        options.IncludeXmlComments(xmlPath);
        options.ResolveConflictingActions(descriptions => descriptions.First());
        options.IgnoreObsoleteActions();
        options.IgnoreObsoleteProperties();
        options.MapType<double?>(() => new OpenApiSchema { Type = "number", Format = "decimal" });
    });
}

static void ConfigureContainer(ContainerBuilder builder)
{
    builder.RegisterModule(new ModuloMediador());
    builder.RegisterModule(new ModuloRepositorio());
    builder.RegisterModule(new ModuloAutomapper());
}