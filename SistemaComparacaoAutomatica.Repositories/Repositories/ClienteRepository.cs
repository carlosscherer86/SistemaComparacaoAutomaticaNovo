using SistemaComparacaoAutomatica.Data.Contexts;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;

namespace SistemaComparacaoAutomatica.Repositories.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(SistemaComparacaoContext DataBase)
            : base(DataBase)
        {
                
        }
    }
}
