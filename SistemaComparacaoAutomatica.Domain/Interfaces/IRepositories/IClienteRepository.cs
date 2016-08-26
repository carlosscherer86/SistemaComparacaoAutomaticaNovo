using SistemaComparacaoAutomatica.Domain.Entities;

namespace SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        Cliente GetClienteByEmail(string Email);
    }
}
