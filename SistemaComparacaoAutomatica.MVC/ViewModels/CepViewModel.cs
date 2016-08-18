using SistemaComparacaoAutomatica.Domain.ValueObject;
using System.ComponentModel.DataAnnotations;

namespace SistemaComparacaoAutomatica.MVC.ViewModels
{
    public class CepViewModel
    {
        [MaxLength(Cep.CepMaxLength)]
        [Display(Name = "CEP")]
        [DisplayFormat(DataFormatString = "{0:#####-###}")]
        public string CepCod { get; set; }

    }
}