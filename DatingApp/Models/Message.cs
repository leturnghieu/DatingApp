using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Models
{
    [Table("Message")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MessageId { get; set; }
        [ForeignKey("User")]
        public Guid SenderId { get; set; }
        [ForeignKey("User")]
        public Guid ReceiverId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime SentDate { get; set; }
    }
}
