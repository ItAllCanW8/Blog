using Blog.Models.BlogViewModels;
using Blog.Models.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.BusinessManagers.Interfaces
{
    public interface IBlogBusinessManager
    {
        IndexViewModel GetIndexViewModel(string searchString, int? page);
        Task<Data.Models.Blog> CreateBlog(CreateViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdateBlog(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
    }
}
