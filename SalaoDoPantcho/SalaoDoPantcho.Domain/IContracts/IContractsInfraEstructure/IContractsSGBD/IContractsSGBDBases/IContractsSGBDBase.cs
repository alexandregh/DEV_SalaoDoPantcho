using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases
{
    public interface IContractsSGBDBase<TEntity, TKey> where TEntity : class
                                                       where TKey : struct
    {
        void InserirPersistence(TEntity entidade);
        void AtualizarPersistence(TEntity entidade);
        void ExcluirPersistence(TEntity entidade);
        ICollection<TEntity> PesquisarTodosPersistence();
        TEntity PesquisarPorIdPersistence(Int32 id);
    }
}