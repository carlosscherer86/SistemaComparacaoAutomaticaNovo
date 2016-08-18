using System;
using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;
using SistemaComparacaoAutomatica.Domain.Interfaces.IUnitOfWork;
using SistemaComparacaoAutomatica.Data.Contexts;
using SistemaComparacaoAutomatica.Repositories.Repositories;

namespace SistemaComparacaoAutomatica.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IClienteRepository _ClienteRepository;
        private IUFRepository _UFRepository;
        private SistemaComparacaoContext _Context = new SistemaComparacaoContext();

        public IClienteRepository ClienteRepository
        {
            get
            {
                if (_ClienteRepository == null)
                {
                    _ClienteRepository = new ClienteRepository(_Context);
                }
                return _ClienteRepository;
            }
        }

        public IUFRepository UFRepository
        {
            get
            {
                if (_UFRepository == null)
                {
                    _UFRepository = new UFRepository(_Context);
                }
                return _UFRepository;
            }
        }

        public void Commit()
        {
            _Context.SaveChanges();
        }
    }
}
