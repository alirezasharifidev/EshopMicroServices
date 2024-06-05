
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (DI)
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);

});

var app = builder.Build();

// Configure the http request pipline. MapGet...
app.MapCarter();

app.Run();
