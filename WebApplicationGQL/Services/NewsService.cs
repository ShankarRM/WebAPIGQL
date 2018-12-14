using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIGQL.Model;

namespace WebAPIGQL.Services
{
    public class NewsService : INewsService
    {
        IList<News> _news;
        public NewsService()
        {
            _news = new List<News>();
            _news.Add(new News() {
                Id = Guid.NewGuid().ToString(),
                Author = "Riyansh",
                Description = "Sample News",
                Title = "Happy News :)",
                PublishedOn = DateTime.Now
            });
        }
        public Task<IEnumerable<News>> GetNewsAsync()
        {
            return Task.FromResult(_news.AsEnumerable());
        }
    }
    public interface INewsService
    {
        Task<IEnumerable<News>> GetNewsAsync();
    }
}
