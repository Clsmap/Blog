using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clsmap.Blog.Pages
{
    public class BlogsModel : PageModel
    {
        public List<Blog> Blogs { get; set; }

        public void OnGet()
        {
            Blogs = new List<Blog>
            {
                new Blog { Id = "1", Title = "Sample1", Author = "Author1", Content = "Test TestTestTestTestTest", PublishedDateTime = DateTime.Now },
                new Blog { Id = "2", Title = "Sample2", Author = "Author2", Content = "Test adaskfasdfhasjdgasgsadg",PublishedDateTime = DateTime.Now.AddDays(-1) },
                new Blog { Id = "3", Title = "Sample3", Author = "Author1", Content = "Test asdgasdfwewetwetwtwett",PublishedDateTime = DateTime.Now.AddHours(-6) },
            };
        }
    }

    public class Blog
    {
        public string Id;

        public string Title;

        public string Author;

        public string Content;

        public DateTime PublishedDateTime;
    }
}
