using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities
{
    public class Post : IEntity
    {
        // Mã chuyên mục
        public int Id { get; set; }

        // Tên chuyên mục, chủ đề 
        public string Title { get; set; }

        // Mô tả thêm về chủ đề 
        public string ShortDescription { get; set; }
            
        // Mô tả thêm về chủ đề 
        public string Description { get; set; }

        // Mô tả thêm về chủ đề 
        public string Meta { get; set; }

        // Tên định danh dùng để tạo URL
        public string UrlSlug { get; set; }

        // Đường dẫn tới file hình ảnh  
        public string ImageUrl { get; set; }

        // Ngày bắt đầu 
        public int ViewCount { get; set; }

        // Đánh dấu chuyên mục được hiển thị trên menu
        public bool Published { get; set; }

        // Ngày bắt đầu 
        public DateTime PostedDate { get; set; }

        // Ngày bắt đầu 
        public DateTime? ModifiedDate { get; set; }

        // Ngày bắt đầu 
        public int CategoryId { get; set; }

        // Ngày bắt đầu 
        public int AuthorId { get; set; }

        //
        public Category Category { get; set; }

        //
        public Author Author { get; set; }

        // Danh sách các bài viết thuộc chuyên mục
        public IList<Tag> Tags { get; set; }
    }
}
