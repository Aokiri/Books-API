﻿namespace my_books.Data.ViewModels
{
    public class BookVM
    {
        public required string Title { get; set; }

        public required string Description { get; set; }

        public required bool IsRead { get; set; }

        // DateRead and Rate is Optional
        public DateTime? DateRead { get; set; }

        public int? Rate { get; set; }

        public required string Genre { get; set; }

        public required string Author { get; set; }

        public required string CoverUrl { get; set; }
    }
}
