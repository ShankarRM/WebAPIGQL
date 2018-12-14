using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIGQL.GraphQL.NewsQST
{
    public class NewsSchema:Schema
    {
        public NewsSchema(NewsQuery newsQuery,IDependencyResolver resolver)
        {
            Query = newsQuery;
            DependencyResolver = resolver;
        }
    }
}
