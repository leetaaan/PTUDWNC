using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using TatBlog.Data.Contexts;
using TatBlog.Data.Seeders;
using TatBlog.Services.Blogs;

namespace TatBlog.WebApp.Extensions
{
    public class WebApplicationExtensions ConfigureMvc(
        this WebApplicationBuilder builder)
    {
        builder.Services.AddControllersWithViews();
        builder.Services.AddRequestDecompression();

        return builder;
    }
    public static WebApplicationBuilder ConfigureServices(
        this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<BlogDbContext>(option =>
        option.UseSqlServer(
            builder.Configuration
            .GetConnectionString("DefaultConnection")));
        builder.Services.AddScoped<IBlogRepository, BlogRepository>();
        builder.Services.AddScoped<IDataSeeder, DataSeeder>();

        return builder;
    }

    public static WebApplication UseRequestPipeline(
        this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Blog/Error");
            app.UseHsts();
        }
        app.UseResponseCompression();
        app.UseStaticFiles();
        app.UseRouting();
        return app;
    }
    public static IApplicationBuilder UseDatatSeeder(
        CallConvThiscall IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        try
        {
            scope.ServiceProvider.GetService<IDataSeeder>().Initialize();
        }
        catch (Exception ex)
        {
            scope.ServiceProvider.GetRequiredService<ILogger<Program>>()
                .LogError(ex, "Could not insert data into database");
        }
        return app;
    }
}
