using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipAssignment.Models
{
    public class CvModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  CvId { get; set; }


        [Required]
        [DisplayName("Your Name")]
        [StringLength(50, MinimumLength = 3)]
        public string YourName { get; set; }


        [Required]
        [DisplayName("Department Name")]
        public int DeptId { get; set; }


        [Required]
        [DisplayName("University Name")]
        [StringLength(200, MinimumLength = 3)]
        public string UniversityName { get; set; }


        [Required]
        [EmailAddress]
        public string YourEmail { get; set; }


        [Required]
        [DisplayName("Your Mobile Number")]
        public string YourPhone { get; set; }

        [Required]
        [DisplayName("Profile Image")]
        public byte[] ProfileImage { get; set; }


        // End top part of my cv

        // Body part of my cv


        [Required]
        [DisplayName("Career Objective")]
        [StringLength(2000, MinimumLength = 3)]
        public string CareerObjective { get; set; }


        [Required]
        [DisplayName("Academic Qualification")]
        [StringLength(2000, MinimumLength = 3)]
        public string AcademicQualification { get; set; }

        // technical skill [ 5 numbers of skill list ]

        // technical skill one


        [DisplayName("Technical Title Skill One")]
        [StringLength(200, MinimumLength = 3)]
        public string TechnicalSkillTitleOne { get; set; }


        [DisplayName("Technical Skill Content One")]
        [StringLength(2000, MinimumLength = 3)]
        public string TechnicalSkillContentOne { get; set; }


        // technical skill  two

        
        [DisplayName("Technical Title Skill Two")]
        [StringLength(200, MinimumLength = 3)]
        public string TechnicalSkillTitleTwo { get; set; }


        [DisplayName("Technical Skill Content Two")]
        [StringLength(2000, MinimumLength = 3)]
        public string TechnicalSkillContentTwo { get; set; }

        // technical skill  three


        [DisplayName("Technical Title Skill Three")]
        [StringLength(200, MinimumLength = 3)]
        public string TechnicalSkillTitleThree { get; set; }


        [DisplayName("Technical Skill Content Three")]
        [StringLength(2000, MinimumLength = 3)]
        public string TechnicalSkillContentThree { get; set; }


        // technical skill  four


        [DisplayName("Technical Title Skill Four")]
        [StringLength(200, MinimumLength = 3)]
        public string TechnicalSkillTitleFour { get; set; }


        [DisplayName("Technical Skill Content Four")]
        [StringLength(2000, MinimumLength = 3)]
        public string TechnicalSkillContentFour { get; set; }


        // technical skill  Five


        [DisplayName("Technical Title Skill Five")]
        [StringLength(200, MinimumLength = 3)]
        public string TechnicalSkillTitleFive { get; set; }


        [DisplayName("Technical Skill Content Five")]
        [StringLength(2000, MinimumLength = 3)]
        public string TechnicalSkillContentFive { get; set; }



        // project and work done [ 5 numbers of done project list ]


        // project one

        [DisplayName("Project Name One")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectNameOne { get; set; }


        [DisplayName("Project Content One")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectContentOne { get; set; }


        // project two

        [DisplayName("Project Name Two")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectNameTwo { get; set; }


        [DisplayName("Project Content Two")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectContentTwo { get; set; }


        // project three

        [DisplayName("Project Name Three")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectNameThree { get; set; }


        [DisplayName("Project Content Three")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectContentThree { get; set; }


        // project four

        [DisplayName("Project Name Four")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectNameFour { get; set; }


        [DisplayName("Project Content Four")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectContentFour { get; set; }


        // project five

        [DisplayName("Project Name Five")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectNameFive { get; set; }


        [DisplayName("Project Content Five")]
        [StringLength(2000, MinimumLength = 3)]
        public string ProjectContentFive { get; set; }


        // extra curricular and work done [ 5 numbers of extra curricular list ]


        [DisplayName("Extra Curricular One")]
        [StringLength(2000, MinimumLength = 3)]
        public string ExtraCurricularOne { get; set; }


        [DisplayName("Extra Curricular Two")]
        [StringLength(2000, MinimumLength = 3)]
        public string ExtraCurricularTwo { get; set; }


        [DisplayName("Extra Curricular Three")]
        [StringLength(2000, MinimumLength = 3)]
        public string ExtraCurricularThree { get; set; }

        [DisplayName("Extra Curricular Four")]
        [StringLength(2000, MinimumLength = 3)]
        public string ExtraCurricularFour { get; set; }


        [DisplayName("Extra Curricular Five")]
        [StringLength(2000, MinimumLength = 3)]
        public string ExtraCurricularFive { get; set; }



        [DisplayName("Field Of Interest ")]
        [StringLength(2000, MinimumLength = 3)]
        public string FieldOfInterest { get; set; }


        // Language


        [Required]
        [DisplayName("Language One")]
        public int LanguageId { get; set; }

        [DisplayName("Language Two")]
        [StringLength(100, MinimumLength = 3)]
        public string LanguageTwo { get; set; }

        [DisplayName("Language Three")]
        [StringLength(100, MinimumLength = 3)]
        public string LanguageThree { get; set; }


        // Personal Details

        [Required]
        [DisplayName("Father Name")]
        [StringLength(50, MinimumLength = 3)]
        public string FatherName { get; set; }


        [Required]
        [DisplayName("Mother Name")]
        [StringLength(50, MinimumLength = 3)]
        public string MotherName { get; set; }


        [Required]
        [DisplayName("Date of your Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DisplayName("Your Gender Name")]
        public int GenderId { get; set; }


        [Required]
        [DisplayName("Marital Status")]
        public int MaritalStatusId { get; set; }


        [Required]
        [DisplayName("Your Nationality")]
        [StringLength(100, MinimumLength = 3)]
        public string Nationality { get; set; }



        [Required]
        [DisplayName("Your NID Number")]
        [StringLength(100, MinimumLength = 3)]
        public string NIDNumber { get; set; }



        [Required]
        [DisplayName("Your Religion")]
        public int ReligionId { get; set; }



        [Required]
        [DisplayName("Permanent Address")]
        [StringLength(1000, MinimumLength = 3)]
        public string PermanentAddress { get; set; }



        [Required]
        [DisplayName("Current Address")]
        [StringLength(100, MinimumLength = 3)]
        public string CurrentAddress { get; set; }

        //  References

        // references one 

        [Required]
        [DisplayName("Teacher Name")]
        [StringLength(100, MinimumLength = 3)]
        public string TeacherNameOne { get; set; }



        [Required]
        [DisplayName("Position Name")]
        [StringLength(500, MinimumLength = 3)]
        public string PositionOne { get; set; }


        
        [Required]
        [DisplayName("Teacher's Email")]
        [EmailAddress]
        public string EmailOne { get; set; }


        [Required]
        [DisplayName("Teacher's Mobile")]
        public string PhoneOne { get; set; }


        // references one 

        [Required]
        [DisplayName("Teacher Name")]
        [StringLength(100, MinimumLength = 3)]
        public string TeacherNameTwo { get; set; }



        [Required]
        [DisplayName("Position Name")]
        [StringLength(500, MinimumLength = 3)]
        public string PositionTwo { get; set; }



        [Required]
        [DisplayName("Teacher's Email")]
        [EmailAddress]
        public string EmailTwo { get; set; }


        [Required]
        [DisplayName("Teacher's Mobile")]
        public string PhoneTwo { get; set; }





        public GenderModel GenderModel { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Religion Religion { get; set; }
        public Department Department { get; set; }
        public Language Language { get; set; }


    }
}
