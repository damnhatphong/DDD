using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TodoList.Persistence.DBContext;

namespace TodoList.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this WebApplicationBuilder builder)
        {
            // readmore about CQRS + Fluent Validator for .net here: https://www.milanjovanovic.tech/blog/cqrs-validation-with-mediatr-pipeline-and-fluentvalidation

            builder.AddFluentValidator();
            builder.AddMediatR();
        }

        internal static void AddFluentValidator(this WebApplicationBuilder builder)
        {
            builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }

        internal static void AddMediatR(this WebApplicationBuilder builder)
        {
            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
                //cfg.AddOpenBehavior(typeof(ValidationBehavior<,>))
            });
        }
    }
}
