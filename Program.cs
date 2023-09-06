using KonicaTracking.Data.Context;
using KonicaTracking.Data.Register;
using KonicaTracking.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NLog;
using NLog.Web;
using System;
using System.Text;
using System.Threading.Channels;

// Inizalice Nlog
var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");



try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Data context configuration.
    //builder.Services.AddTransient<AppContext>();
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddDbContext<AppDbContext>(option =>
        option.UseSqlServer(connectionString), ServiceLifetime.Transient);

    // Dependencies injection
    builder.Services.AddDependencies();

    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();
   
    // JWT
    var appSettingsSection = builder.Configuration.GetSection("AppSettings");    
    var secret = appSettingsSection["Secret"];

    
    builder.Services.AddSingleton(new AppSettings { Secret = secret });

    var key = Encoding.ASCII.GetBytes(secret);
    builder.Services.AddAuthentication(d =>
    {
        d.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        d.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
        .AddJwtBearer(d =>
        {
            d.RequireHttpsMetadata = false;
            d.SaveToken = true;
            d.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });

    var app = builder.Build();
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}