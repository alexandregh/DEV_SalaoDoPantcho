using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesServicos;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDServicos;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesServicos
{
    public class DomainServicesServico : DomainServicesBase<Servicos, Int32>, IContractsDomainServicesServico
    {
        #region Atributo

        private IContractsSGBDServico servicoServico;

        #endregion

        #region Construtor

        public DomainServicesServico(IContractsSGBDServico servicoServico)
            : base(servicoServico)
        {
            this.servicoServico = servicoServico;
        }

        #endregion

        #region Implementação Métodos Serviços

        public ICollection<Servicos> PesquisarServicosPorGeneroService(GeneroServico generoServico)
        {           
            return servicoServico.PesquisarServicosPorGeneroPersistence(generoServico);
        }

        public Servicos PesquisarServicosPorNomeService(string nome)
        {
            return servicoServico.PesquisarServicosPorNomePersistence(nome);
        }

        public ICollection<Servicos> PesquisarServicosPorPrecoService(decimal preco)
        {            
            return servicoServico.PesquisarServicosPorPrecoPersistence(preco);
        }

        #endregion
    }
}