namespace Bookstore.Entities.Quotes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public class QuoteMap
    {
        [Key]
        public int Id { get; set; }

        public string Tags { get; set; }

        public string Quote { get; set; }

        public string Lang { get; set; }

        public string Author { get; set; }

    }
}