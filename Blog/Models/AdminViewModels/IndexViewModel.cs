using System.Collections.Generic;

namespace Blog.Models.AdminViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Data.Models.Blog> Blogs { get; set; }
    }
}
