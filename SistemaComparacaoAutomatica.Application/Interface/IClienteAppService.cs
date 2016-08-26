using SistemaComparacaoAutomatica.Domain.Entities;

namespace SistemaComparacaoAutomatica.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        bool IsEmailUnique(string Email);
    }
}
