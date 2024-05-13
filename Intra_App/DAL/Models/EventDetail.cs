using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Intra_App_Prj.DAL.Models
{
    public class EventDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Uid { get; set; }

        [Required]
        public string E_Uid { get; set; }

        [Required]
        public string Eid { get; set; }

        [Required]
        public string Response { get; set; }

        [ForeignKey("E_Uid")]
        public User User { get; set; }

        [ForeignKey("Eid")]
        public Event Event { get; set; }
    }
}
