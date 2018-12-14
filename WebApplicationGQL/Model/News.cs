using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIGQL.Services;

namespace WebAPIGQL.Model
{
    public class News 
    {
        public string Id { get; set; }
        public String Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }
        public News()
        {
            
        }

    }
    
}
