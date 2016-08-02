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
            try
            {
                return servicoServico.PesquisarServicosPorGeneroPersistence(generoServico);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Servicos PesquisarServicosPorNomeService(string nome)
        {
            try
            {
                return servicoServico.PesquisarServicosPorNomePersistence(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Servicos> PesquisarServicosPorPrecoService(decimal preco)
        {
            try
            {
                return servicoServico.PesquisarServicosPorPrecoPersistence(preco);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}