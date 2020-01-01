using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipAssignment.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }


        [Required]
        [DisplayName("Department Name")]
        [StringLength(150, MinimumLength = 3)]
        public string DeptName { get; set; }


        [Required]
        [DisplayName("Enter Date of Today")]
        public DateTime EntryDate { get; set; }


        public List<CvModel> CvModel { get; set; }
    }
}
