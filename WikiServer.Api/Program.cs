using Microsoft.EntityFrameworkCore;
using WikiServer.Api.ModelServices;
using WikiServer.Api.ModelServices.Interfaces;
using WikiServer.Application.Interfaces.Comment;
using WikiServer.Application.Interfaces.Files;
using WikiServer.Application.Interfaces.Folders;
using WikiServer.Application.Services.Comment;
using WikiServer.Application.Services.Files;
using WikiServer.Application.Services.Folders;
using WikiServer.Domain.AggregateModels.FolderModels;
using WikiServer.Domain.SeedWorks;
using WikiServer.Infrastructure.Database;
using WikiServer.Infrastructure.Interfaces;
using WikiServer.Infrastructure.Repositories;
using WikiServer.Infrastructure.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

// Configure CORS to allow all origins, methods, and headers
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policyBuilder =>
    {
        policyBuilder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader();
    });
});

// Add services to the container.
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IFolderService, FolderService>();
builder.Services.AddScoped<IFolderModelService, FolderModelService>();
builder.Services.AddScoped<IFileModelService, FileModelService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentModelService, CommentModelService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IEFRepository<>), typeof(BaseRepository<>));

// Configure Entity Framework with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("WikiServer.Api")));

// Add AutoMapper for object mapping
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add Controllers and Swagger for API documentation
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable CORS middleware with the defined policy
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

// Map the controllers
app.MapControllers();

app.Run();
