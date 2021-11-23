using System;
using System.ComponentModel.DataAnnotations;

namespace firstApplication.Models
{

    public class Projects
    {
        [Key]
        public int ProjectID {get; set;}
        [Required(ErrorMessage = "StartProject is required ")]
        [DataType(DataType.Date)]
        [Display(Name ="StartProject")]

        public string StartProject {get; set;}
        [Required(ErrorMessage = "FinishProject is required ")]
        [ DataType(DataType.Date)]
        [Display(Name ="FinishProjectProject")]

        public string FinishProject {get; set;}
         [Required(ErrorMessage = "DescriptionProject is required ")]
        [Display(Name ="DescriptionProject")]

        public string DescriptionProject {get; set;}

        //Referencias para Leaders
        [Required(ErrorMessage = "Leader is required ")]
        [Display(Name ="Leaders")]
        public int LeadersID {get; set;}

        public Leaders Leader {get; set;}
       

    }
}