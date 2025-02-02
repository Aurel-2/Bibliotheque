namespace Bibliotheque.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; } = DateTime.UtcNow;
        public DateTime? ReturnDate { get; set; }

        // Clés étrangères
        public int BookId { get; set; }
        public int UserId { get; set; }

        // Relations
        public required Book Book { get; set; }
        public required User User { get; set; }
    }
}
