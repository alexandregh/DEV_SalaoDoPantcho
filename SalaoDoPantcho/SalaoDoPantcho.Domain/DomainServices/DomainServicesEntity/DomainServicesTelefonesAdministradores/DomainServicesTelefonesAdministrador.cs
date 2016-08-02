using System;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesTelefonesAdministradores;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDTelefonesAdministradores;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesTelefonesAdministradores
{
    public class DomainServicesTelefonesAdministrador : DomainServicesBase<TelefonesAdministrador, Int32>, IContractsDomainServicesTelefonesAdministrador
    {
        #region Atributo

        private IContractsSGBDTelefonesAdministrador servicoTelefonesAdministrador;

        #endregion

        #region Construtor

        public DomainServicesTelefonesAdministrador(IContractsSGBDTelefonesAdministrador servicoTelefonesAdministrador)
            : base(servicoTelefonesAdministrador)
        {
            this.servicoTelefonesAdministrador = servicoTelefonesAdministrador;
        }

        #endregion

        #region Implementação Métodos Serviços

        // ainda vai ser implementado...

        #endregion
    }
}