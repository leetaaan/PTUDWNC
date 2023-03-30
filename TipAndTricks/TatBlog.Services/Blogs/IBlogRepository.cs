using TatBlog.Core.Constraints;
using TatBlog.Core.Contracts;
using TatBlog.Core.DTO;
using TatBlog.Core.Entities;

namespace TatBlog.Services.Blogs
{
    public interface IBlogRepository
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
        Task<IPagedList<TagItem>> GetCategoryItemsAsync(
           IPagingParams pagingParams,
           CancellationToken cancellationToken = default);
        Task<IPagedList<Post>> GetPagedPostsAsync(
            PostQuery condition, int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default);
    }
}
