using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.AdminViewModels
{
    public class AboutViewModel
    {
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }

        [Display(Name = "Sub-Header")]
        public string SubHeader { get; set; }
        public string Content { get; set; }
    }
}
