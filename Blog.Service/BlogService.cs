using Blog.Data;
using Blog.Service.Interfaces;
using System.Threading.Tasks;

namespace Blog.Service
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public BlogService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Data.Models.Blog> Add(Data.Models.Blog blog) {
            applicationDbContext.Add(blog);
            await applicationDbContext.SaveChangesAsync();

            return blog;
        }
    }
}
