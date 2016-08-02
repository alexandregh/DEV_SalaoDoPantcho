using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAcessorios;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAcessorios;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesAcessorios
{
    public class AppServicesAcessorio : AppServicesBase<Acessorios, Int32>, IContractsAppServicesAcessorio
    {
        #region Atributo

        private IContractsDomainServicesAcessorio appServicesAcessorios;

        #endregion

        #region Construtor

        public AppServicesAcessorio(IContractsDomainServicesAcessorio appServicesAcessorios)
            : base(appServicesAcessorios)
        {
            this.appServicesAcessorios = appServicesAcessorios;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public Acessorios AppServicesPesquisarAcessorioPorNome(string nome)
        {
            return this.appServicesAcessorios.PesquisarAcessorioPorNomeService(nome);
        }

        #endregion
    }
}