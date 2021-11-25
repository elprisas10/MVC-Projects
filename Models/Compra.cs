using System;
using System.ComponentModel.DataAnnotations;

namespace firstApplication.Models
{
    public class Compra 
    {
        [Key]
//Se agrego compras
        public int CompraId {get; set;}
        [Required(ErrorMessage="Nombre is requiered!")]
        [Display(Name="Nombre")]

        public string Nombre {get; set;}
        [Required(ErrorMessage="Tefl is requiered!")]
        [Display(Name="Tefl")]

        public string Tefl {get; set;}
        [Required(ErrorMessage="Email is requiered!")]
        [Display(Name="Email")]

        public string Email {get; set;}

        public int CompraID {get; set;}

        public Compra Compra {get; set;} 



 }
}