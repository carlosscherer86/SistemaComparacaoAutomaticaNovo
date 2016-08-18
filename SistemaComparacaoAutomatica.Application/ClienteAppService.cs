using SistemaComparacaoAutomatica.Application.Interface;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.Interfaces.IServices;

namespace SistemaComparacaoAutomatica.Application
{
    public class ClienteAppService : AppServiceBase<Cliente> , IClienteAppService
    {
        private readonly IClienteService _ClienteService;

        public ClienteAppService(IClienteService clienteService)
            :base(clienteService)
        {
            _ClienteService = clienteService;
        }
    }
}
