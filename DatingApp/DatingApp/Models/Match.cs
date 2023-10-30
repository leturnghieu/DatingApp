using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.Models
{
    [Table("Match")]
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MatchId { get; set; }
        [ForeignKey("User")]
        public Guid UserId1 { get; set; }
        [ForeignKey("User")]
        public Guid UserId2 { get; set; }
        [Required]
        public DateTime MatchedDate { get; set; }
    }
}
