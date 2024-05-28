using Microsoft.EntityFrameworkCore;
using ShortingLinks.Data;
using ShortingLinks.Data.Repositories;
using Microsoft.EntityFrameworkCore.Design;

namespace ShortingLinks.Web;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();

        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen();

        //var connection = Configuration.GetConnectionString(nameof(ShortingLinkDbContext));
        var connection = Configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ShortingLinkDbContext>(options => options.UseSqlServer(connection));
        services.AddScoped<ILinkRepository, LinkRepository>();
    }
}