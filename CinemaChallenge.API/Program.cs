using CinemaChallenge.Application.Adapters;
using CinemaChallenge.Application.DTOs;
using CinemaChallenge.Application.Interfaces;
using CinemaChallenge.Application.UseCases;
using CinemaChallenge.Application.UseCases.Movies;
using CinemaChallenge.Application.UseCases.Users;
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

//adapters
builder.Services.AddScoped<IEncrypter, Encrypter>();

//usecases
builder.Services.AddScoped<ICreate<Movie, MovieDto>, CreateMovie>();
builder.Services.AddScoped<ICreate<User, UserDto>, CreateUser>();
builder.Services.AddScoped<IFind<Movie, IMovie>, FindMovie>();
builder.Services.AddScoped<IUpdate<IMovie>, UpdateMovie>();
builder.Services.AddScoped<IUpdate<MovieDto>, UpdateMovie>();
builder.Services.AddScoped<IDelete, DeleteMovie>();

//repositories
builder.Services.AddScoped<ICreateRepository<Movie>, EFCreateMovie>();
builder.Services.AddScoped<IFindRepository<Movie>, EFFindMovie>();
builder.Services.AddScoped<IUpdateRepository<IMovie>, EFUpdateMovie>();
builder.Services.AddScoped<IDeleteRepository, EFDeleteMovie>();
builder.Services.AddScoped<ICreateRepository<User>, EFCreateUser>();

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
