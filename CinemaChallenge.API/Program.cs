using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Application.UseCases;
using CinemaChallenge.Domain.Entities;
using CinemaChallenge.Domain.Interfaces;
using CinemaChallenge.Infra.Data.EntityFramework;
using CinemaChallenge.Infra.Data.Interfaces;
using CinemaChallenge.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//usecases
builder.Services.AddScoped<ICreateMovie, CreateMovie>();
builder.Services.AddScoped<IFindMovie, FindMovie>();
builder.Services.AddScoped<IUpdateMovie, UpdateMovie>();
builder.Services.AddScoped<IDeleteMovie, DeleteMovie>();

//repositories
builder.Services.AddScoped<ICreateRepository<Movie>, EFCreateMovie>();
builder.Services.AddScoped<IFindRepository<Movie>, EFFindMovie>();
builder.Services.AddScoped<IUpdateRepository<IMovie>, EFUpdateMovie>();
builder.Services.AddScoped<IDeleteRepository, EFDeleteMovie>();

//db
builder.Services.AddDbContext<AppDbContext>();

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
