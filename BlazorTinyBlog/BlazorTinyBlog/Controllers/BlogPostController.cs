using BlazorTinyBlog.Shared.Models;
using BlazorTinyBlog.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTinyBlog.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpGet]
        public async Task<ActionResult<List<BlogPost>>> GetAllBlogPostsAsync()
        {
            var posts = await _blogPostService.GetAllPostAsync();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BlogPost>> GetAllBlogPostsByIdAsync(int id)
        {
            var posts = await _blogPostService.GetBlogPostByIdAsync(id);
            return Ok(posts);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateBlogPostAsync(BlogPost post)
        {
            var result = await _blogPostService.CreateBlogPost(post);
            return (result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<int>> UpdateBlogPostAsync(int id, BlogPost post)
        {
            var result = await _blogPostService.UpdateBlogPost(id, post);
            return (result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteBlogPostAsync(int id)
        {
            var result = await _blogPostService.DeleteBlogPost(id);
            return (result);
        }
    }
}
