using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesTelefonesClientes;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDTelefonesClientes;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesTelefonesClientes
{
    public class DomainServicesTelefonesCliente : DomainServicesBase<TelefonesCliente, Int32>, IContractsDomainServicesTelefonesCliente
    {
        #region Atributo

        private IContractsSGBDTelefonesCliente servicoTelefonesCliente;

        #endregion

        #region Construtor

        public DomainServicesTelefonesCliente(IContractsSGBDTelefonesCliente servicoTelefonesCliente)
            : base(servicoTelefonesCliente)
        {
            this.servicoTelefonesCliente = servicoTelefonesCliente;
        }

        #endregion

        #region Implementação Métodos Serviços

        public TelefonesCliente PesquisarTelefonePorDDDService(byte ddd)
        {
            return servicoTelefonesCliente.PesquisarTelefonePorDDDPersistence(ddd);
        }

        public TelefonesCliente PesquisarTelefonePorNumeroService(int numero)
        {            
            return servicoTelefonesCliente.PesquisarTelefonePorNumeroPersistence(numero);
        }

        public TelefonesCliente PesquisarTelefonePorTipoTelefoneService(TipoTelefones tipoTelefone)
        {            
            return servicoTelefonesCliente.PesquisarTelefonePorTipoTelefonePersistence(tipoTelefone);            
        }


        public ICollection<TelefonesCliente> PesquisarTelefonesPorDDDService(byte ddd)
        {            
            return servicoTelefonesCliente.PesquisarTelefonesPorNumeroPersistence(ddd);
        }

        public ICollection<TelefonesCliente> PesquisarTelefonesPorNumeroService(int numero)
        {            
            return servicoTelefonesCliente.PesquisarTelefonesPorNumeroPersistence(numero);
        }

        public ICollection<TelefonesCliente> PesquisarTelefonesPorTipoTelefoneService(TipoTelefones tipoTelefone)
        {            
            return servicoTelefonesCliente.PesquisarTelefonesPorTipoTelefonePersistence(tipoTelefone);
        }

        #endregion
    }
}