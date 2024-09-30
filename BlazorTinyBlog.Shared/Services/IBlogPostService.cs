using BlazorTinyBlog.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTinyBlog.Shared.Services
{
    public interface IBlogPostService
    {
        Task<List<BlogPost>> GetAllPostAsync();
        Task<BlogPost> GetBlogPostByIdAsync(int id);
        Task<int> CreateBlogPost(BlogPost post);
        Task<int> UpdateBlogPost(int id, BlogPost post);
        Task<int> DeleteBlogPost(int id);
    }
}
