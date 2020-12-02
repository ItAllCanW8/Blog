using Blog.BusinessManagers.Interfaces;
using Blog.Data.Models;
using Blog.Models.BlogViewModels;
using Blog.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.BusinessManagers
{
    public class BlogBusinessManager : IBlogBusinessManager
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IBlogService blogService;

        public BlogBusinessManager(UserManager<ApplicationUser> userManager, IBlogService blogService) {
            this.userManager = userManager;
            this.blogService = blogService;
        }
        public async Task<Data.Models.Blog> CreateBlog(CreateBlogViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal) {
            Data.Models.Blog blog = createBlogViewModel.Blog;

            blog.Creator = await userManager.GetUserAsync(claimsPrincipal);
            blog.CreatedOn = System.DateTime.Now;

            return await blogService.Add(blog);
        }
    }
}
