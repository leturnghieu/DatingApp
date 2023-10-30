using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Models
{
    [Table("Profile")]
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProfileId { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Interest { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
