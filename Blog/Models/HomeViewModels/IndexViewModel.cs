﻿using PagedList.Core;

namespace Blog.Models.HomeViewModels
{
    public class IndexViewModel
    {
        public IPagedList<Data.Models.Blog> Blogs { get; set; }
        public string SearchString { get; set; }
        public int PageNumber { get; set; }
    }
}
