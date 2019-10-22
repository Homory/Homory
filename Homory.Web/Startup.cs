using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Homory.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder application)
        {
            application.UseHsts();
            application.UseHttpsRedirection();
            application.UseStaticFiles();
            application.UseRouting();
        }
    }
}
