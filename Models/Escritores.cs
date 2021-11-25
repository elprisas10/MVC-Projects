using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace firstApplication.Models
{
    public class Escritores
    {
        //definir propiedades
        [Key]
        public int EscritoresID {get; set;}
        [Required(ErrorMessage="Firstname is required!")]
        [Display(Name="Firstname")]
        public string firstName {get; set;}
        [Required(ErrorMessage="Lastname is required!")]
        [Display(Name="Lastname")]
        public string lastName {get; set;}
        [Required(ErrorMessage="Email is required!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email",  Prompt="email@domain.com")]
        public string email {get; set;}
        [Required(ErrorMessage="Gender is required!")]
        [Display(Name="Gender")]
        public string gender {get; set;}
        [Required(ErrorMessage="Address is required!")]
        [Display(Name="Address")]
        [StringLength(100)]
        public string address {get; set;}

        public ICollection<Periodico> periodicos {get; set;} = new List<Periodico>();
    }
}