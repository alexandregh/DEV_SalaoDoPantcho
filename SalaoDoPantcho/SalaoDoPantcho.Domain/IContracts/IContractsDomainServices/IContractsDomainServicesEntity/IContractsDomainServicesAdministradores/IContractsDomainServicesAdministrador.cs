using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores
{
    public interface IContractsDomainServicesAdministrador : IContractsDomainServicesBase<Administradores, Int32>
    {
        // métodos específicos...
        #region Serviços

        void VincularClienteAPromocaoService(string login, string email);
        void VincularClienteAPromocaoDatasComemorativasService(string login, string email);
        void VincularClienteAProdutosService(string login, string email);
        void VincularClienteAServicoService(string login, string email);

        #endregion
    }
}