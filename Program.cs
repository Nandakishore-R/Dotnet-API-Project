using Microsoft.EntityFrameworkCore;
using APIApplication.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); 
// Configure SQLite database
builder.Services.AddDbContext<StudentContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("StudentConnection")));
//builder.Services.AddDbContext<TodoContext>(opt =>
//    opt.UseSqlite(builder.Configuration.GetConnectionString("TodoListConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseForwardedHeaders();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
