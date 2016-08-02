using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesPromocoes
{
    public interface IContractsDomainServicesPromocao : IContractsDomainServicesBase<Promocoes, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Promocoes PesquisarPromocaoPorNomeService(string nome);
        ICollection<Promocoes> PesquisarPromocoesPorDataInicioService(DateTime dataInicio);
        ICollection<Promocoes> PesquisarPromocoesPorDataFimService(DateTime dataFim);
        ICollection<Promocoes> PesquisarPromocoesPorDataInicioFimService(DateTime dataInicio, DateTime dataFim);

        #endregion
    }
}