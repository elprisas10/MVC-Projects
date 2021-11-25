using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace firstApplication.Models
{

    public class vendedores
    {


        //definir las propiedades
        [Key]
        public int vendedoresID { get; set; }

        [Required(ErrorMessage = "Firtname is requiered!")]
        [Display(Name = "Firstname")]
        public string FirsName { get; set; }
        [Required(ErrorMessage = "Lastname is requiered!")]
        [Display(Name = "Lastname")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Email is requiered!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is requiered!")]
        [Display(Name = "Gender", Prompt="email@domain.com")]

        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is requiered!")]
        [Display(Name = "Address")]
        [StringLength(100)]
        public string Address { get; set; }


        public ICollection<Product> Product { get;set; } = new List<Product>();
