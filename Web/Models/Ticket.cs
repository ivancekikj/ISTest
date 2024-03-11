using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? ConcertId { get; set; }
        public Concert? Concert { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
        [Required]
        public int NumberOfPeople { get; set; }
    }
}
