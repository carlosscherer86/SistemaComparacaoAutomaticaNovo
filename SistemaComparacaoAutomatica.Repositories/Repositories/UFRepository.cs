using SistemaComparacaoAutomatica.Data.Contexts;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;

namespace SistemaComparacaoAutomatica.Repositories.Repositories
{
    public class UFRepository : RepositoryBase<UF>, IUFRepository
    {
        public UFRepository(SistemaComparacaoContext DataBase)
            :base(DataBase)
        {
                
        }
    }
}
