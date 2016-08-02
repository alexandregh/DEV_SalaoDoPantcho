using System;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEnderecosAdministradores;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEnderecosAdministradores;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesEnderecosAdministradores
{
    public class AppServicesEnderecosAdministrador : AppServicesBase<EnderecosAdministrador, Int32>, IContractsAppServicesEnderecosAdministrador
    {
        #region Atributo

        private IContractsDomainServicesEnderecosAdministrador appServicesEnderecosAdministrador;

        #endregion

        #region Construtor

        public AppServicesEnderecosAdministrador(IContractsDomainServicesEnderecosAdministrador appServicesEnderecosAdministrador)
            : base(appServicesEnderecosAdministrador)
        {
            this.appServicesEnderecosAdministrador = appServicesEnderecosAdministrador;
        }

        #endregion

        #region Implementação Métodos Aplicação

        // ainda vai ser implementado...

        #endregion
    }
}