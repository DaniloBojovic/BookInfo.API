using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Api.Models
{
    public class BookForCreation
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
    }
}
