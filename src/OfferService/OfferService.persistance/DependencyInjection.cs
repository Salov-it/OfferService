using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using OfferService.Application.Interface;


namespace OfferService.persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["DbConnection"];

            IOfferContext _context;
            switch (config["DbType"])
            {
                case "InMemory":
                    {
                        services.AddDbContext<OfferContext>(opt =>
                        {
                            opt.UseInMemoryDatabase("1");
                        });
                        break;
                    }
                case "Postgres":
                    {
                        services.AddDbContext<OfferContext>(options =>
                        {
                            options.UseNpgsql(connectionString);
                        });
                        break;
                    }
                case "SQLite":
                    {
                        services.AddDbContext<OfferContext>(options =>
                        {
                            options.UseSqlite(connectionString);
                        });
                        break;
                    }
                default:
                    {
                        throw new Exception();
                    }
            }

            services.AddScoped<IOfferContext>(provider => provider.GetService<OfferContext>());
            return services;
        }
    }
}
