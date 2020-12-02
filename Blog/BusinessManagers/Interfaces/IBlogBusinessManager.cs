using Blog.Models.BlogViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.BusinessManagers.Interfaces
{
    public interface IBlogBusinessManager
    {
        Task<Data.Models.Blog> CreateBlog(CreateBlogViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal);
    }
}
