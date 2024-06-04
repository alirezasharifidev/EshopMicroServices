
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (DI)

var app = builder.Build();

// Configure the http request pipline. MapGet...

app.Run();
