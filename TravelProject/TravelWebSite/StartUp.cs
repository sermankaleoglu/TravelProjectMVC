namespace TravelProject
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();//Yönlendirme kullanılacağını belirtir.
            app.UseEndpoints(endpoints=>
            {
                endpoints.MapControllerRoute(
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}