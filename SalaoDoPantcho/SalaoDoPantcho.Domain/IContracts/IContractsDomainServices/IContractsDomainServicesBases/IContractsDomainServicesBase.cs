using System;
using System.Collections.Generic;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases
{
    public interface IContractsDomainServicesBase<TEntity, TKey> where TEntity : class
                                                                 where TKey : struct
    {
        void InserirService(TEntity entidade);
        void AtualizarService(TEntity entidade);
        void ExcluirService(TEntity entidade);
        ICollection<TEntity> PesquisarTodosService();
        TEntity PesquisarPorIdService(Int32 id);
    }
}