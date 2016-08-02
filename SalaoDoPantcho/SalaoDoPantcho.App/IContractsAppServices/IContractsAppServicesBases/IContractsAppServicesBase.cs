using System;
using System.Collections.Generic;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases
{
    public interface IContractsAppServicesBase<TEntity, TKey> where TEntity : class
                                                              where TKey : struct
    {
        void AppServicesInserir(TEntity entidade);
        void AppServicesAtualizar(TEntity entidade);
        void AppServicesExcluir(TEntity entidade);
        ICollection<TEntity> AppServicesPesquisarTodos();
        TEntity AppServicesPesquisarPorId(Int32 id);
    }
}