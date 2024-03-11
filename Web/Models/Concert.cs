using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Concert
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime? DateAndTime { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        public int Price { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
