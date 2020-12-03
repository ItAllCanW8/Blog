using Blog.BusinessManagers.Interfaces;
using Blog.Data.Models;
using Blog.Models.AdminViewModels;
using Blog.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.BusinessManagers
{
    public class AdminBusinessManager : IAdminBusinessManager
    {
        private UserManager<ApplicationUser> userManager;
        private IBlogService blogService;

        public AdminBusinessManager(
            UserManager<ApplicationUser> userManager,
            IBlogService blogService)
        {
            this.userManager = userManager;
            this.blogService = blogService;
        }

        public async Task<IndexViewModel> GetAdminDashboard(ClaimsPrincipal claimsPrincipal)
        {
            var applicationUser = await userManager.GetUserAsync(claimsPrincipal);
            return new IndexViewModel
            {
                Blogs = blogService.GetBlogs(applicationUser)
            };
        }
    }
}
