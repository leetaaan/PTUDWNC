﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagBlog.Core.Constraints;

namespace TagBlog.WinApp
{
    public class PagingParams : IPagingParams
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
        public string SortColumn { get; set; } = "id";
        public string SortOrder { get; set; } = "ASC";
    }
}
