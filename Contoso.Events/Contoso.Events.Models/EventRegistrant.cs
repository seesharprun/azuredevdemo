using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Events.Models
{
    public class EventRegistrant
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Prompt = "First Name")]
        [Required]
        [StringLength(150)]
        public string FirstName { get; set; }

        [Display(Prompt = "Last Name")]
        [Required]
        [StringLength(150)]
        public string LastName { get; set; }

        [Display(Prompt = "E-Mail Address")]
        [Required]
        [StringLength(500)]
        public string EmailAddress { get; set; }

        [Display(Prompt = "Department")]
        [Required]
        [StringLength(250)]
        public string Department { get; set; }

        [ScaffoldColumn(false)]
        public DateTimeOffset Timestamp { get; set; }

        [ScaffoldColumn(false)]
        public virtual Event Event { get; set; }
    }
}
