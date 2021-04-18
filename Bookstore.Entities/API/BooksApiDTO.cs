using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Entities.API.Models
{
    public class BooksApiDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string  Publisher { get; set; }
    }
}
