using System.ComponentModel.DataAnnotations;

namespace SistemaComparacaoAutomatica.MVC.ViewModels
{
    public class EmailViewModel
    {
        [Required]
        [Display(Name ="E-mail")]
        [EmailAddress]
        public string Endereco { get; set; }
    }
}