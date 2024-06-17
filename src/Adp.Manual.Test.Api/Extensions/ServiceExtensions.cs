using Adp.Manual.Test.Core.Interfaces;
using Adp.Manual.Test.Core.Services;

namespace Adp.Manual.Test.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
