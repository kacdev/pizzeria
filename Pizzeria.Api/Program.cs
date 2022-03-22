using MediatR;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Application;
using Pizzeria.Application.Commands;
using Pizzeria.Application.Queries;
using Pizzeria.Infrastructure;
using Pizzeria.Infrastructure.DAL;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<PizzeriaDbContext>();
db.Database.Migrate();

app.MapGet("/api/Pizza", async (IMediator _mediator) => await _mediator.Send(new GetPizzas()));
app.MapPost("/api/Pizza", async (IMediator _mediator, CreatePizza command) => await _mediator.Send(command));

app.Run();
