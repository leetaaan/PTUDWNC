﻿
using TatBlog.Data.Contexts;
using TatBlog.Data.Seeders;
using TatBlog.Services.Blogs;
using TatBlog.WinApp;

namespace TatBlog.WinApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var context = new BlogDbContext();




            //5
            IBlogRepository blogRepo = new BlogRepository(context);

            var pagingParams = new PagingParams
            {
                PageNumber = 1,
                PageSize = 5,
                SortColumn = "name",
                SortOrder = "DESC"
            };
            var tagsList = await blogRepo.GetPagedTagsAsync(pagingParams);

            Console.WriteLine("{0,-5}{1,-50}{2,10}",
                "ID", "Name", "Count");

            foreach (var item in tagsList)
            {
                Console.WriteLine("{0,-5}{1,-50}{2,10}",
                    item.Id, item.Name, item.PostCount);
            }





            //4
            //IBlogRepository blogRepo = new BlogRepository(context);

            //var categories = await blogRepo.GetCategoryItemsAsync();

            //Console.WriteLine("{0,-5}{1,-50}{2,10}",
            //    "ID", "Name", "Count");
            //foreach (var item in categories)
            //{
            //    Console.WriteLine("{0,-5}{1,-50}{2,10}",
            //        item.Id, item.Name, item.PostCount);
            //}


            //3
            //IBlogRepository blogRepo = new BlogRepository(context);

            //var posts = await blogRepo.GetPopularArticleAsync(3);

            //foreach (var post in posts)
            //{
            //    Console.WriteLine("ID               :{0}", post.Id);
            //    Console.WriteLine("Title            :{0}", post.Title);
            //    Console.WriteLine("View             :{0}", post.ViewCount);
            //    Console.WriteLine("Date             :{0:MM/dd/yyyy}", post.PostDate);
            //    Console.WriteLine("Author           :{0}", post.Author);
            //    Console.WriteLine("Categor          :{0}", post.Category);
            //    Console.WriteLine("".PadRight(80, '-'));



            //    2
            //            var posts = context.Posts
            //                .Where(p => p.Published)
            //                .OrderBy(p => p.Title)
            //                .Select(p => new
            //                {
            //                    Id = p.Id,
            //                    Title = p.Title,
            //                    ViewCount = p.ViewCount,
            //                    PostDate = p.PostDate,
            //                    Author = p.Author.FullName,
            //                    Category = p.Category.Name
            //                })
            //                .ToList();
            //    foreach (var post in posts)
            //    {
            //        Console.WriteLine("ID               :{0}", post.Id);
            //        Console.WriteLine("Title            :{0}", post.Title);
            //        Console.WriteLine("View             :{0}", post.ViewCount);
            //        Console.WriteLine("Date             :{0:MM/dd/yyyy}", post.PostDate);
            //        Console.WriteLine("Author           :{0}", post.Author);
            //        Console.WriteLine("Categor          :{0}", post.Category);
            //        Console.WriteLine("".PadRight(80, '-'));
            //    }
            //}

            //        1
            //        var seeder = new DataSeeder(context);

            //seeder.Initialize();
            //        var authors = context.Authors.ToList();

            //Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12}",
            //            "ID", "FullName", "Email", "Jonied Date");

            //        foreach (var author in authors)
            //        {
            //            Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12:MM/dd/yyyy}",
            //                author.Id, author.FullName, author.Email, author.JoinedDate);
            //        }


        }
    }
}
