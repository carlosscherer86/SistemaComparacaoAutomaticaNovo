using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;
using System;

namespace SistemaComparacaoAutomatica.Domain.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IClienteRepository ClienteRepository { get; }
        IUFRepository UFRepository { get; }
        void Commit();
    }
}
