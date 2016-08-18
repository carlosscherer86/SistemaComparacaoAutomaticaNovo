using SistemaComparacaoAutomatica.Domain.ValueObject;
using System.ComponentModel.DataAnnotations;

namespace SistemaComparacaoAutomatica.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [MaxLength(Endereco.EnderecoClienteMaxLength)]
        [Required]
        [Display(Name ="Endereço")]
        public string EnderecoCliente { get; set; }

        [MaxLength(Endereco.BairroClienteMaxLength)]
        public string Bairro { get; set; }

        [MaxLength(Endereco.CidadeClienteMaxLength)]
        public string Cidade { get; set; }

        public CepViewModel Cep { get; set; }

        [MaxLength(Endereco.ComplementoMaxLength)]
        public string Complemento { get; set; }

        [MaxLength(Endereco.NumeroClienteMaxLength)]
        public string Numero { get; set; }
    }
}