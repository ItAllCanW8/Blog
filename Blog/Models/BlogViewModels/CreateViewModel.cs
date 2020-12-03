using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.BlogViewModels
{
    public class CreateViewModel
    {
        [Required, Display(Name = "Header Img")]
        public IFormFile BlogHeaderImage { get; set; }
        public Data.Models.Blog Blog { get; set; }
    }
}
