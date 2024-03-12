namespace slide2_staticfile
{
    public class startup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStaticFiles();
            }
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello static file");
            });
        }
    }
}
