using Blog.Data;
using Blog.Data.Models;
using Blog.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public Data.Models.Blog GetBlog(int blogId)
        {
            return applicationDbContext.Blogs.FirstOrDefault(blog => blog.Id == blogId);
        }
        public IEnumerable<Data.Models.Blog> GetBlogs(ApplicationUser applicationUser)
        {
            return applicationDbContext.Blogs
                .Include(blog => blog.Creator)
                .Include(blog => blog.Approver)
                .Include(blog => blog.Posts)
                .Where(blog => blog.Creator == applicationUser);
        }
        public async Task<Data.Models.Blog> Add(Data.Models.Blog blog)
        {
            applicationDbContext.Add(blog);
            await applicationDbContext.SaveChangesAsync();

            return blog;
        }
        public async Task<Data.Models.Blog> Update(Data.Models.Blog blog)
        {
            applicationDbContext.Update(blog);
            await applicationDbContext.SaveChangesAsync();

            return blog;
        }
    }
}
