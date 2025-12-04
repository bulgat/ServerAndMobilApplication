using Microsoft.EntityFrameworkCore;
using ServerAndMobil.Server.model;
using TriangleDocker.dataBasa;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDBcontent>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
/*
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", builder => {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});
*/
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
           policy => policy
               .AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod());
});
// Другие конфигурации сервиса  



builder.Services.AddGraphQLServer().AddQueryType<QueryGraph>();
builder.Services.AddErrorFilter<GraphQLErrorFilter>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();



var app = builder.Build();

app.UseCors(builder =>
{
    builder
          .WithOrigins("http://localhost:51376", "https://localhost:51376")
          .SetIsOriginAllowedToAllowWildcardSubdomains()
          .AllowAnyHeader()
          .AllowCredentials()
          .WithMethods("GET", "PUT", "POST", "DELETE", "OPTIONS")
          .SetPreflightMaxAge(TimeSpan.FromSeconds(3600));

}
);

app.MapGraphQL("/graphql");

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
