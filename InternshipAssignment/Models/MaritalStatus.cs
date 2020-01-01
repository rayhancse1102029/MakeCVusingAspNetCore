using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipAssignment.Models
{
    public class MaritalStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaritalStatusId { get; set; }


        [Required]
        [DisplayName("Marital Status Name")]
        [StringLength(20, MinimumLength = 3)]
        public string MaritalStatusName { get; set; }


        [Required]
        [DisplayName("Enter Date of Today")]
        public DateTime EntryDate { get; set; }


        public List<CvModel> CvModel { get; set; }
    }
}
