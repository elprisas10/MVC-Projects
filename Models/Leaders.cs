using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace firstApplication.Models
{

    public class Leaders
    {
        //definir las propiedades
        [Key]
        public int LeadersID {get; set;}
        [Required(ErrorMessage="FirstName is Required")]
        [Display(Name="FirstName")]
        public string Name {get; set;}
         [Required(ErrorMessage="LastName is Required")]
        [Display(Name="LastName")]
        public string Lastname {get; set;}
         [Required(ErrorMessage="Email is Required")]
         [DataType(DataType.EmailAddress)]
           [Display(Name="Email", Prompt ="email@domain.com")]

        public string Email {get; set;}
         [Required(ErrorMessage="Gender is Required")]
           [Display(Name="Gender")]

        public string Gender {get; set;}
         [Required(ErrorMessage="Address is Required")]
           [Display(Name="Address")]
           [StringLength(100)]
        public string Address {get; set;}

        private ICollection<Projects> project = new List<Projects>();

    }
}