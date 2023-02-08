using Microsoft.EntityFrameworkCore;
using Raccioon.Core.Contracts.Orders.Commands;
using Raccioon.Core.Contracts.Orders.Queries;
using Raccioon.Infra.Sql.Commands.Common;
using Raccioon.Infra.Sql.Commands.Orders.Contracts;
using Raccioon.Infra.Sql.Queries.Common;
using Raccioon.Infra.Sql.Queries.Orders.Contracts;
using System.Globalization;

Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");
Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fa-IR");

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();


//builder.Services.AddZaminWebUserInfoService(c => { c.DefaultUserId = "1"; }, true);

#region  DbContext 
builder.Services.AddDbContext<OrderCommandDbContext>(c =>
c.UseSqlServer(builder.Configuration.GetConnectionString("Commands")));

builder.Services.AddDbContext<OrderQueryDbContext>(c =>
c.UseSqlServer(builder.Configuration.GetConnectionString("Queries")));

#endregion

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
