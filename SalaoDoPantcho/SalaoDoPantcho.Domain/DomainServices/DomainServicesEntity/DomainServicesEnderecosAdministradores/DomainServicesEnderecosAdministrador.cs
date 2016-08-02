using System;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEnderecosAdministradores;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEnderecosAdministradores;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesEnderecosAdministradores
{
    public class DomainServicesEnderecosAdministrador : DomainServicesBase<EnderecosAdministrador, Int32>, IContractsDomainServicesEnderecosAdministrador
    {
        #region Atributo

        private IContractsSGBDEnderecosAdministrador servicoEnderecosAdministrador;

        #endregion

        #region Construtor

        public DomainServicesEnderecosAdministrador(IContractsSGBDEnderecosAdministrador servicoEnderecosAdministrador)
            : base(servicoEnderecosAdministrador)
        {
            this.servicoEnderecosAdministrador = servicoEnderecosAdministrador;
        }

        #endregion

        #region Implementação Métodos Serviços

        // ainda vai er implementado...

        #endregion
    }
}