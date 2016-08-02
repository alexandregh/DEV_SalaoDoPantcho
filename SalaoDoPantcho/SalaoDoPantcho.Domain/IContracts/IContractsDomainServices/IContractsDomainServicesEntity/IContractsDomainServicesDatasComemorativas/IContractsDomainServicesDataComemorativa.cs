using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesDatasComemorativas
{
    public interface IContractsDomainServicesDataComemorativa : IContractsDomainServicesBase<DatasComemorativas, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        DatasComemorativas PesquisarDatasComemorativasPorDescricaoService(string descricao);
        DatasComemorativas PesquisarDatasComemorativasPorDescricaoEDataComemorativaService(string descricao, DateTime dataComemorativa);

        #endregion
    }
}