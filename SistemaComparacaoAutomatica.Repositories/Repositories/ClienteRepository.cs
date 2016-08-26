using System;
using SistemaComparacaoAutomatica.Data.Contexts;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;
using System.Linq;

namespace SistemaComparacaoAutomatica.Repositories.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(SistemaComparacaoContext DataBase)
            : base(DataBase)
        {
                
        }

        public Cliente GetClienteByEmail(string Email)
        {
            return _DataBase.Clientes.Where(c => c.Email.Endereco.Equals(Email)).FirstOrDefault();
        }
    }
}
