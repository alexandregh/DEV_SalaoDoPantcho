using System;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAdministradores
{
    public interface IContractsAppServicesAdministrador : IContractsAppServicesBase<Administradores, Int32>
    {
        // métodos específicos...
        #region Serviços

        void AppServicesVincularClienteAPromocao(string login, string email);
        void AppServicesVincularClienteAPromocaoDatasComemorativas(string login, string email);
        void AppServicesVincularClienteAProdutos(string login, string email);
        void AppServicesVincularClienteAServico(string login, string email);

        #endregion
    }
}