
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (DI)
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);

});
builder.Services.AddMarten(opt =>
{
    opt.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();


var app = builder.Build();

// Configure the http request pipline. MapGet...
app.MapCarter();

app.Run();
