﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagBlog.Core.Constraints;
using TagBlog.Core.DTO;
using TagBlog.Core.Entities;

namespace TatBlog.Services.Blogs
{
    internal interface IBlogRepository
    {
        Task<Post> GetPostAsync(
            int year, 
            int month, 
            string slug, 
            CancellationToken cancellationToken = default);
        Task<IList<Post>> GetPopularArticleAsync(
            int numPosts, 
            CancellationToken cancellationToken = default);
        Task<bool> IsPostSlugExistAsync(
            int postId, string slug, 
            CancellationToken cancellationToken = default);
        Task IncreaseViewCountAsync(
            int postId, 
            CancellationToken cancellationToken = default);
        Task<IList<CategoryItem>> GetCategoryItemsAsync(
            bool showOnMenu = false,
            CancellationToken cancellationToken = default);
        Task<IPagedList<TagItem>> GetPagedTagsAsync(
            IPagingParams pagingParams,
            CancellationToken cancellationToken = default);
        Task GetPagedTagsAsync(TagBlog.WinApp.PagingParams pagingParams);
    }
}
