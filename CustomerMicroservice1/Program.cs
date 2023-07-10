var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddCors();

var app = builder.Build();

//app.UseCors(builder =>
//{
//    builder.WithOrigins("https://localhost:7069/");
//});

// Configure the HTTP request pipeline.
app.UseCors(builder => builder
       .AllowAnyHeader()
       .AllowAnyMethod()
       .AllowAnyOrigin()
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
