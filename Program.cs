using DotNetEnv;
using spendlock_backend.SeedWork;
using spendlock_backend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

Env.Load();

builder.Services.AddSingleton<SupabaseService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<VisitorService>();
builder.Services.AddScoped<AuthUsersService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
