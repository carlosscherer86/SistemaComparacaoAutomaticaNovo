using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaComparacaoAutomatica.MVC.ViewModels
{
    public class ClientesViewModel
    {
        [Key]
        public int CodCliente { get; set; }

        [Required]
        public byte[] Senha { get; set; }

        [Required]
        [Display(Name ="Confirmação de Senha")]
        public byte[] ConfirmacaoSenha { get; set; }

        [ScaffoldColumn(false)]
        public Guid TokenAlteracaoSenha { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public EmailViewModel Email { get; set; }

        [Required]
        public EnderecoViewModel Endereco { get; set; }

        [Required]
        [Display(Name = "Data Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public bool Administrador { get; set; }

        public int UFID { get; set; }

        public virtual UFViewModel UF { get; set; }
    }
}