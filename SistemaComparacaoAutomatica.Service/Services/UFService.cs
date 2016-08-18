using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;
using SistemaComparacaoAutomatica.Domain.Interfaces.IServices;
using SistemaComparacaoAutomatica.Domain.Interfaces.IUnitOfWork;

namespace SistemaComparacaoAutomatica.Service.Services
{
    public class UFService : ServiceBase<UF>,IUFService
    {
        private readonly IUnitOfWork _UnitOfWork;

        public UFService(IUnitOfWork unitOfWork)
            :base(unitOfWork.UFRepository)
        {
            _UnitOfWork = unitOfWork;
        }
    }
}
