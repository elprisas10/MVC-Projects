using System;
using System.ComponentModel.DataAnnotations;

namespace firstApp.Models
{
    public class Periodico
    {
        //definir propiedades
        [Key]
        public int PeriodicoID {get; set;}
        [Required(ErrorMessage="Description is required!")]
        [Display(Name="Description")]
        public string description {get; set;}
        [Required(ErrorMessage="Date is required!")]
        [Display(Name="Date")]
        public string date {get; set;}
        [Required(ErrorMessage="Name is required!")]
        [Display(Name="Name")]
        public string name {get; set;}
        [Required(ErrorMessage ="Escritor es requerido!")]
        [Display(Name ="Escritor")]
        public int escritor {get; set;}

        public Escritores Escritor{get; set;}
    }
}