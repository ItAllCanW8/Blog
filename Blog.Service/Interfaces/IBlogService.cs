using Blog.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Service.Interfaces
{
    public interface IBlogService
    {
        Data.Models.Blog GetBlog(int blogId);
        IEnumerable<Data.Models.Blog> GetBlogs(ApplicationUser applicationUser);
        Task<Data.Models.Blog> Add(Data.Models.Blog blog);
        Task<Data.Models.Blog> Update(Data.Models.Blog blog);
    }
}
