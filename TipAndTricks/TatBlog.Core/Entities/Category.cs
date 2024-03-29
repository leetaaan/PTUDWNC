﻿using TatBlog.Core.Contracts;

namespace TatBlog.Core.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        // Tên chuyên mục, tên chủ đề
        public string Name { get; set; }

        // Tên định danh dùng để tạo URL
        public string UrlSlug { get; set; }

        // Mô tả thêm về chuyên mục 
        public string Description { get; set; }

        // Đánh dấu chuyên mục được hiển thị trên menu
        public bool ShowOnMenu { get; set; }

        // Danh sách các bài viết thuộc chuyên mục
        public IList<Post> Posts { get; set; }
    }
}
