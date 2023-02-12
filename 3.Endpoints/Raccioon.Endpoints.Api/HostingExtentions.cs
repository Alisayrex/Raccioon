using Microsoft.EntityFrameworkCore;
using Raccioon.Core.Contracts.Orders.Commands;
using Raccioon.Core.Contracts.Orders.Queries;
using Raccioon.Infra.Sql.Commands.Common;
using Raccioon.Infra.Sql.Commands.Orders.Contracts;
using Raccioon.Infra.Sql.Queries.Common;
using Raccioon.Infra.Sql.Queries.Orders.Contracts;
using Serilog;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.ApplicationServices.Events;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Extensions.DependencyInjection;

namespace Raccioon.Endpoints.Api

{
    public static class HostingExtentions
    {

        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
           // OrderCommandDbContext orderCmDbCtx;
           
            string cnn = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Raccioon_Order;Data Source=.;TrustServerCertificate=true";
           
            builder.Services.AddZaminParrotTranslator(c =>
            {
                c.ConnectionString = cnn;
                c.AutoCreateSqlTable = true;
                c.SchemaName = "dbo";
                c.TableName = "ParrotTranslations";
                c.ReloadDataIntervalInMinuts = 1;
            });

            //builder.Services.AddSingleton<CommandDispatcherDecorator, CustomCommandDecorator>();
            //builder.Services.AddSingleton<QueryDispatcherDecorator, CustomQueryDecorator>();
            //builder.Services.AddSingleton<EventDispatcherDecorator, CustomEventDecorator>();

            builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
            builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

            builder.Services.AddZaminWebUserInfoService(c => { c.DefaultUserId = "1"; }, true);

            builder.Services.AddZaminAutoMapperProfiles(option =>
            {
                option.AssmblyNamesForLoadProfiles = "Raccioon_Order";
            });

            builder.Services.AddZaminMicrosoftSerializer();

            builder.Services.AddZaminInMemoryCaching();

            #region  DbContext 

            builder.Services.AddDbContext<OrderCommandDbContext>(c =>
            c.UseSqlServer(builder.Configuration.GetConnectionString("Commands")));

            builder.Services.AddDbContext<OrderQueryDbContext>(c =>
            c.UseSqlServer(builder.Configuration.GetConnectionString("Queries")));

            #endregion

            builder.Services.AddZaminApiCore("Zamin", "Raccioon_Order");

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();





            return builder.Build();

        }
        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            app.UseZaminApiExceptionHandler();
            app.UseSerilogRequestLogging();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}