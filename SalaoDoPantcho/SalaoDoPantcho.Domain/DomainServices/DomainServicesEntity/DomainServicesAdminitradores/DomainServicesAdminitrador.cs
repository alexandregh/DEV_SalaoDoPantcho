using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesAdminitradores
{
    public class DomainServicesAdminitrador : DomainServicesBase<Administradores, Int32>, IContractsDomainServicesAdministrador
    {
        #region Atributo

        private IContractsSGBDAdministrador servicoAdministrador;

        #endregion

        #region Construtor

        public DomainServicesAdminitrador(IContractsSGBDAdministrador servicoAdministrador)
            : base(servicoAdministrador)
        {
            this.servicoAdministrador = servicoAdministrador;
        }

        #endregion

        #region Implementação Métodos Serviços

        public void VincularClienteAProdutosService(string login, string email)
        {
            servicoAdministrador.VincularClienteAProdutosPersistence(login, email);
        }

        public void VincularClienteAPromocaoDatasComemorativasService(string login, string email)
        {
            servicoAdministrador.VincularClienteAPromocaoDatasComemorativasPersistence(login, email);
        }

        public void VincularClienteAPromocaoService(string login, string email)
        {   
            servicoAdministrador.VincularClienteAPromocaoPersistence(login, email);
        }

        public void VincularClienteAServicoService(string login, string email)
        { 
            servicoAdministrador.VincularClienteAServicoPersistence(login, email);
        }

        #endregion
    }
}