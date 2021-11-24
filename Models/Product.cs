using System;
using System.ComponentModel.DataAnnotations;

namespace firstApplication.Models
{
    public class Product
    {
        [Key]
        public int productId{get;set;}
        [Required(ErrorMessage="Nombre is requiered!")]
        [Display(Name="Nombre")]

        public string nombre{get;set;}
        [Required(ErrorMessage="Descripcion is requiered!")]
        [Display(Name="Descripcion")]


        public string descripcion{get;set;}
        [Required(ErrorMessage="Precio is requiered!")]
        [Display(Name="Precio")]


        public string precio{get;set;}

        //referencias para vendedor

        [Required(ErrorMessage="Vendedor is requiered!")]
        [Display(Name="Vendedor")]

        public int vendedorID {get;set;}

        


    }





}