﻿namespace lesson11_backend.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BookTag> BookTags { get; set; }
    }
}
