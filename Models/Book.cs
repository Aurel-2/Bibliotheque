namespace Bibliotheque.Models
{
    public class Book(int id, string title, string author, string genre, int publicationyear, bool available)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public string Genre { get; set; } = genre;
        public int PublicationYear { get; set; } = publicationyear;
        public bool Available { get; set; } = available;
    }
}
