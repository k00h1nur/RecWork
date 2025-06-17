using API.Extensions;
using NLog;
using NLog.Web;

var logger = LogManager
    .Setup()
    .LoadConfigurationFromFile("nlog.config")
    .GetCurrentClassLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    ServiceExtension.RegisterMapsterConfiguration();
    builder.Services
        .AddAuthentication(builder.Configuration)
        .RegisterServices(builder.Configuration);

    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGenWithJwtTokenHeaders();

    // Enable serving static files from wwwroot folder
    builder.Services.AddDirectoryBrowser();

    // Configure static file options
    builder.Services.Configure<StaticFileOptions>(options =>
    {
        options.ServeUnknownFileTypes = true; // Serve all file types
    });

    // Allow CORS for any request
    builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
    });

    Application.Extensions.ServiceExtension.ConfigureValidator(builder.Services);
    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseCors();

    app.UseAuthentication();
    app.UseAuthorization();

    app.UseStaticFiles(); 

    app.MapGet("/health", () => Results.Ok(new
    {
        status = "healthy",
        timestamp = DateTime.UtcNow,
        version = "1.0.0"
    }));

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application encountered a critical error.");
    throw;
}
finally
{
    LogManager.Shutdown();
}