
namespace PharmacyManagement.API.Configuration
{
    using FluentValidation.AspNetCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;
    using PharmacyManagement.Core.Model;
    using System.Collections.Generic;
    using System.Linq;
    public static class ValidatorConfig
    {
        public static IServiceCollection AddValidator(this IServiceCollection services)
        {
            services.AddControllers()
                     .AddFluentValidation
                     (
                         fv =>
                             fv.RegisterValidatorsFromAssemblyContaining<Medicine>()
                     );
            services.Configure<ApiBehaviorOptions>
            (
                options => options.InvalidModelStateResponseFactory = context =>
                {
                    List<string> errors = context.ModelState
                                                 .Values
                                                 .SelectMany(modelStateEntry => modelStateEntry.Errors.Select(error => error.ErrorMessage))
                                                 .ToList();

                    return new BadRequestObjectResult
                    (
                        new { errors }
                    );
                }
            );
            return services;
        }

       
    }
}
