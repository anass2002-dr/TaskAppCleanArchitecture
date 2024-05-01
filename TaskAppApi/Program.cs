using Microsoft.EntityFrameworkCore;
using TaskAppCleanArchitecture.Application.Repository;
using TaskAppCleanArchitecture.Application.Service;
using TaskAppCleanArchitecture.Application.ServiceImp;
using TaskAppCleanArchitecture.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager ConfigurationManager = builder.Configuration;

// Add Database service
builder.Services.AddDbContext<TachesDbContext>(optionsAction: options => options.UseSqlServer(ConfigurationManager.GetConnectionString("defaultConnection"),
    b=>b.MigrationsAssembly("TaskAppApi")
    ));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<ITaskDoService,TaskDoService>();
builder.Services.AddScoped<ITaskDoService, TaskDoService>();
builder.Services.AddScoped<ITaskDoRepository, TaskDoRepository>();

builder.Services.AddScoped<ITaskStatutService, TaskStatutService>();
builder.Services.AddScoped<ITaskStatutRepository, TaskStatutRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline. 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
