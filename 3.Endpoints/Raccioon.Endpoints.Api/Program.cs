//using Microsoft.EntityFrameworkCore;
//using Raccioon.Core.Contracts.Orders.Commands;
//using Raccioon.Core.Contracts.Orders.Queries;
//using Raccioon.Infra.Sql.Commands.Common;
//using Raccioon.Infra.Sql.Commands.Orders.Contracts;
//using Raccioon.Infra.Sql.Queries.Common;
//using Raccioon.Infra.Sql.Queries.Orders.Contracts;
//using System.Globalization;

//Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");
//Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fa-IR");

//var builder = WebApplication.CreateBuilder(args);




//// Add services to the container.


////builder.Services.AddControllers();
////builder.Services.AddEndpointsApiExplorer();

//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle




////builder.Services.AddZaminWebUserInfoService(c => { c.DefaultUserId = "1"; }, true);


//builder.Services.AddAuthorization();

//var app = builder.Build();



//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthentication();
//app.UseAuthorization();

//app.MapControllers();

//app.Run();


using Raccioon.Endpoints.Api;
using Zamin.Extensions.DependencyInjection;
using Zamin.Utilities.SerilogRegistration.Extensions;

SerilogExtensions.RunWithSerilogExceptionHandling(() =>
{
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.AddZaminSerilog(c =>
    {
        c.ApplicationName = "Raccioon_Order";
        c.ServiceName = "Raccioon_OrderService";
        c.ServiceVersion = "1.0";
    }).ConfigureServices().ConfigurePipeline();
    app.Run();
});