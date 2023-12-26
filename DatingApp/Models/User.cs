using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DatingApp.Models.Enums;

namespace DatingApp.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string Avata { get; set; }
        [Required]
        public string Images {  get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public bool IsEmailConfirmed { get; set; }
    }
}
