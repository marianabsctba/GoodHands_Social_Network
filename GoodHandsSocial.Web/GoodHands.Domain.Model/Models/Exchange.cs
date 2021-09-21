using System;
using System.ComponentModel.DataAnnotations;

namespace GoodHands.Domain.Model.Models
{
    public class Exchange
    {
        public int Id { get; set; }

        [Display(Name = "Tipo da troca")]
        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string DonationName { get; set; }

        [Display(Name = "Breve descrição")]
        [StringLength(50, MinimumLength = 3)]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string Description { get; set; }

        [Display(Name = "Tem frete?")]
        public bool HaveCourier { get; set; }

        [Display(Name = "Quantidade de itens")]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data máxima disponível - até: ")]
        public DateTime MaximumDate { get; set; }
    }
}