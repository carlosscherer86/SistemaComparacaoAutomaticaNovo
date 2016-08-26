using System;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;
using SistemaComparacaoAutomatica.Domain.Interfaces.IServices;
using SistemaComparacaoAutomatica.Domain.Interfaces.IUnitOfWork;

namespace SistemaComparacaoAutomatica.Service.Services
{
    public class ClienteService : ServiceBase<Cliente> , IClienteService
    {
        private readonly IUnitOfWork _UnitOfWork;

        public ClienteService(IUnitOfWork unitOfWork)
            :base(unitOfWork.ClienteRepository)
        {
            _UnitOfWork = unitOfWork;
        }

        public Cliente GetClienteByEmail(string Email)
        {
            return _UnitOfWork.ClienteRepository.GetClienteByEmail(Email);
        }

        public bool IsEmailUnique(string Email)
        {
            return this.GetClienteByEmail(Email) == null;
        }
    }
}
