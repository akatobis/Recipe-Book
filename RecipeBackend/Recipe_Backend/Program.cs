using Microsoft.EntityFrameworkCore;
using Recipe_Backend.Aplication;
using Recipe_Backend.Aplication.Repository;
using Recipe_Backend.Infrastructure;
using Recipe_Backend.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers();

builder.Services.AddDbContext<RecipeDbContext>( options =>
    options.UseSqlServer( builder.Configuration.GetConnectionString( "Recipe_Book" ) ?? throw new InvalidOperationException( "Conection string 'Recipe_Book' not found." ) ) );

builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( !app.Environment.IsDevelopment() )
{
    app.UseExceptionHandler( "/Error" );
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

//app.UseSwagger();

//app.UseSwaggerUI( options =>
//{
//    options.SwaggerEndpoint( "/swagger/v1/swagger.json", "v1" );
//    options.RoutePrefix = string.Empty;
//});

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();

app.Run();
