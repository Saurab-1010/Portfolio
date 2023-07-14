using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string? Name { get; set; }
        public int? Number { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? Message { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
