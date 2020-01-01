using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipAssignment.Models
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LanguageId { get; set; }


        [Required]
        [DisplayName("Department Name")]
        [StringLength(150, MinimumLength = 3)]
        public string LanguageName { get; set; }


        [Required]
        [DisplayName("Enter Date of Language")]
        public DateTime EntryDate { get; set; }


        public List<CvModel> CvModel { get; set; }

    }
}
