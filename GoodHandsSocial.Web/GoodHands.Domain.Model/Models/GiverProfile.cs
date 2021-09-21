using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoodHands.Domain.Model.Models
{
    public class GiverProfile
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome")]
        public string GiverName { get; set; }

        [Display(Name = "Sobrenome")]
        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string GiverLastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Aniversário")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Biografia")]
        public string Biografy { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "CEP")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "O {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Complemento")]
        public string AddressDetails { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "É pessoa física?")]
        public bool LegalStatus { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "É doador?")]
        public bool IsDonor { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Quer fazer trocas?")]
        public bool IsExchanger { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Foto")]
        public string ImageUri { get; set; }

        public string UserId { get; set; }

        public ICollection<Post> Posts { get; set; }


    }
}