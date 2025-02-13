﻿namespace Bibliotheque.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public bool Available { get; set; }
        public ICollection<Loan>? Loans { get; set; }

        // Parameterless constructor for EF Core
        public Book()
        {
            Loans = new List<Loan>();
        }


    }
}
