using System.Threading.Tasks;

namespace Blog.Service.Interfaces
{
    public interface IBlogService
    {
        Task<Data.Models.Blog> Add(Data.Models.Blog blog);
    }
}
