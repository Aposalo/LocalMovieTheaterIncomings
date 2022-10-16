using LocalMovieTheaterIncomings.Core.Repositories;
using LocalMovieTheaterIncomings.Core.Repositories.Interfaces;
using LocalMovieTheaterIncomings.Core.Services;
using LocalMovieTheaterIncomings.Core.Services.Interfaces;

namespace LocalMovieTheaterIncomings
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IFoodRepository, FoodRepository>();
            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddTransient<IFoodService, FoodService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<IFinancialsService, FinancialsService>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
