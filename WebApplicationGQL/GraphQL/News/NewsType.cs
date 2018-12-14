using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIGQL.Model;

namespace WebAPIGQL.GraphQL.NewsQST
{
    public class NewsType:ObjectGraphType<News>
    {
        public NewsType()
        {
            Field(c=>c.Id);
            Field(c => c.Title);
            Field(c => c.Description);
            Field(c => c.Author);
            Field(c => c.PublishedOn);
            
        }
    }
}
