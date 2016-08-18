using System.Collections.Generic;

namespace SistemaComparacaoAutomatica.Domain.Entities
{
    public class UF
    {
        public int CodUF { get; set; }

        public const int AbreviaturaUFMaxLength = 2;
        public string Abreviatura { get; set; }

        public const int DescricaoUFMaxLength = 45;
        public string Descricao { get; set; }

        public virtual IEnumerable<Cliente> Clientes { get; set; }
    }
}