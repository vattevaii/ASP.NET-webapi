using Microsoft.EntityFrameworkCore;
using asp.net_folder.Models2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
   options.AddPolicy(name: "_AllowedOrigins",
                     policy =>
                     {
                        policy.WithOrigins("http://localhost:5533");
                     });
});

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<FriendContext>(opt =>
    opt.UseInMemoryDatabase("Videos"));
builder.Services.AddDbContext<VideoCollectionContext>(opt =>
    opt.UseInMemoryDatabase("Videos"));
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("_AllowedOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
