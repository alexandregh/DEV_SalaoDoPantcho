using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAcessorios
{
    public interface IContractsDomainServicesAcessorio : IContractsDomainServicesBase<Acessorios, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Acessorios PesquisarAcessorioPorNomeService(string nome);

        #endregion
    }
}