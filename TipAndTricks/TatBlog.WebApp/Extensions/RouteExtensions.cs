﻿namespace TatBlog.WebApp.Extensions
{
    public class RouteExtensions
    {
        public static IEndpointRouteBuilder UseBlogRoutes(this IEndpointRouteBuilder endpoints) 
        {
            endpoints.MapControllerRoute(
                name: "post-by-category",
                pattern: "blog/category/{slug}",
                defaults: new { controllers = "Blog", action = "Category" });
            endpoints.MapControllerRoute(
                name: "post-by-tag",
                pattern: "blog/tag/{slug}",
                defaults: new { controllers = "Blog", action = "Tag" });
            endpoints.MapControllerRoute(
                name: "single-post",
                pattern: "blog/post/{year:int}/{month:int}/{day:int}/{slug}",
                defaults: new { controllers = "Blog", action = "Post" });
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Blog}/{action=Index}/{id?}");
            return endpoints;
        }
    }
}
