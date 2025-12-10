using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularStrike.Server.model
{
    public class Score
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        [ScaffoldColumn(true)]
        [StringLength(5, ErrorMessage = "The PhotoFileName value cannot exceed 4 characters. ")]
        public string? Name { set; get; }
        [Required]
        public string? Family { set; get; }

    }
}
