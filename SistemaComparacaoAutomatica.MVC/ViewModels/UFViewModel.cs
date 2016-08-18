using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaComparacaoAutomatica.MVC.ViewModels
{
    public class UFViewModel
    {
        [Key]
        public int CodUF { get; set; }

        [Display(Name ="Estado")]
        public string Abreviatura { get; set; }

        public string Descricao { get; set; }

        public virtual IEnumerable<ClientesViewModel> Clientes { get; set; }
    }
}