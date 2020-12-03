using Blog.Data.Models;
using System.Collections.Generic;

namespace Blog.Models.AdminViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}