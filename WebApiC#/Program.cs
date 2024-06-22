var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Platzi - Clase Inyeccion de dependencias - Inyeccion de dependencia mediante AddScoped
//Cada que se inyecte la interfaz se creara un nuevo objeto de la clase
builder.Services.AddScoped<IHelloWorldService, HelloWorldService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseWelcomePage();

//app.UseTimeMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();
