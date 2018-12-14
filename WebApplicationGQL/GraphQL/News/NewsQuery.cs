using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIGQL.Services;

namespace WebAPIGQL.GraphQL.NewsQST
{
    public class NewsQuery:ObjectGraphType<object>
    {
        public NewsQuery(INewsService newsService)
        {
            Name = "NewsQuery";
            Field<ListGraphType<NewsType>>(
                "News",
                resolve: context => newsService.GetNewsAsync()
                );
        }
    }
}
