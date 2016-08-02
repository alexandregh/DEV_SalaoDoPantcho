using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesServicos;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesServicos;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesServicos
{
    public class AppServicesServico : AppServicesBase<Servicos, Int32>, IContractsAppServicesServico
    {
        #region Atributo

        private IContractsDomainServicesServico appServicesServico;

        #endregion

        #region Construtor

        public AppServicesServico(IContractsDomainServicesServico appServicesServico)
            : base(appServicesServico)
        {
            this.appServicesServico = appServicesServico;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public ICollection<Servicos> AppServicesPesquisarServicosPorGenero(GeneroServico generoServico)
        {
            return this.appServicesServico.PesquisarServicosPorGeneroService(generoServico);
        }

        public Servicos AppServicesPesquisarServicosPorNome(string nome)
        {
            return this.appServicesServico.PesquisarServicosPorNomeService(nome);
        }

        public ICollection<Servicos> AppServicesPesquisarServicosPorPreco(decimal preco)
        {
            return this.appServicesServico.PesquisarServicosPorPrecoService(preco);
        }

        #endregion
    }
}