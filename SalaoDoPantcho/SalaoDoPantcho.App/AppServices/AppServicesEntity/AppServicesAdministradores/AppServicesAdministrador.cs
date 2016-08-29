using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAdministradores;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesAdministradores
{
    public class AppServicesAdministrador : AppServicesBase<Administradores, Int32>, IContractsAppServicesAdministrador
    {
        #region Atributo

        private IContractsDomainServicesAdministrador appServicesAdministrador;

        #endregion

        #region Construtor

        public AppServicesAdministrador(IContractsDomainServicesAdministrador appServicesAdministrador)
            : base(appServicesAdministrador)
        {
            this.appServicesAdministrador = appServicesAdministrador;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public void AppServicesVincularClienteAProdutos(string login, string email)
        {
            appServicesAdministrador.VincularClienteAProdutosService(login, email);
        }

        public void AppServicesVincularClienteAPromocao(string login, string email)
        {
            appServicesAdministrador.VincularClienteAPromocaoService(login, email);
        }

        public void AppServicesVincularClienteAPromocaoDatasComemorativas(string login, string email)
        {
            appServicesAdministrador.VincularClienteAPromocaoDatasComemorativasService(login, email);
        }

        public void AppServicesVincularClienteAServico(string login, string email)
        {
            appServicesAdministrador.VincularClienteAServicoService(login, email);
        }

        #endregion
    }
}