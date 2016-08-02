using System;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesTelefonesAdministradores;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesTelefonesAdministradores;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesTelefonesAdministradores
{
    public class AppServicesTelefonesAdministrador : AppServicesBase<TelefonesAdministrador, Int32>, IContractsAppServicesTelefonesAdministrador
    {
        #region Atributo

        private IContractsDomainServicesTelefonesAdministrador appServicesTelefonesAdministrador;

        #endregion

        #region Construtor

        public AppServicesTelefonesAdministrador(IContractsDomainServicesTelefonesAdministrador appServicesTelefonesAdministrador)
            : base(appServicesTelefonesAdministrador)
        {
            this.appServicesTelefonesAdministrador = appServicesTelefonesAdministrador;
        }

        #endregion

        #region Implementação Métodos Aplicação



        #endregion
    }
}