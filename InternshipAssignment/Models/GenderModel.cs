using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipAssignment.Models
{
    public class GenderModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenderId { get; set; }


        [Required]
        [DisplayName("Gender Name")]
        [StringLength(20,MinimumLength = 3)]
        public string GenderName { get; set; }

        
        [Required]
        [DisplayName("Enter Date of Today")]
        public DateTime EntryDate { get; set; }


        public List<CvModel> CvModel { get; set; }

    }
}
