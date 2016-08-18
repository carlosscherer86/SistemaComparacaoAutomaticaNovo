using SistemaComparacaoAutomatica.Application.Interface;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.Interfaces.IServices;

namespace SistemaComparacaoAutomatica.Application
{
    public class UFAppService : AppServiceBase<UF>, IUFAppService
    {
        private readonly IUFService _UFService;

        public UFAppService(IUFService ufService)
            :base(ufService)
        {
            _UFService = ufService;
        }
    }
}
