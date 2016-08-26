using SistemaComparacaoAutomatica.Domain.Entities;

namespace SistemaComparacaoAutomatica.Domain.Interfaces.IServices
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        Cliente GetClienteByEmail(string Email);
        bool IsEmailUnique(string Email);
    }
}
