using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Events.Models
{
    public class Event
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string EventKey { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        
        [ScaffoldColumn(false)]
        [DataType(DataType.Url)]
        public string SignInDocumentUrl { get; set; }
        
        [ScaffoldColumn(false)]
        public virtual EventLocation Location { get; set; }

        [ScaffoldColumn(false)]
        public virtual ICollection<EventRegistrant> Registrants { get; set; }
    }
}