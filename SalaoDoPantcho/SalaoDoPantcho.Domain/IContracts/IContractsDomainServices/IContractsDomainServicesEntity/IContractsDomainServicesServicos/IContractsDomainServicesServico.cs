using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesServicos
{
    public interface IContractsDomainServicesServico : IContractsDomainServicesBase<Servicos, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Servicos PesquisarServicosPorNomeService(string nome);
        ICollection<Servicos> PesquisarServicosPorPrecoService(decimal preco);
        ICollection<Servicos> PesquisarServicosPorGeneroService(GeneroServico generoServico);

        #endregion
    }
}