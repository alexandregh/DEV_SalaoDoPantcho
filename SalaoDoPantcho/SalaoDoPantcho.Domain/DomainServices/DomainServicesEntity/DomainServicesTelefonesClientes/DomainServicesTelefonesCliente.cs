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
            try
            {
                return servicoTelefonesCliente.PesquisarTelefonePorDDDPersistence(ddd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TelefonesCliente PesquisarTelefonePorNumeroService(int numero)
        {
            try
            {
                return servicoTelefonesCliente.PesquisarTelefonePorNumeroPersistence(numero);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TelefonesCliente PesquisarTelefonePorTipoTelefoneService(TipoTelefones tipoTelefone)
        {
            try
            {
                return servicoTelefonesCliente.PesquisarTelefonePorTipoTelefonePersistence(tipoTelefone);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ICollection<TelefonesCliente> PesquisarTelefonesPorDDDService(byte ddd)
        {
            try
            {
                return servicoTelefonesCliente.PesquisarTelefonesPorNumeroPersistence(ddd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<TelefonesCliente> PesquisarTelefonesPorNumeroService(int numero)
        {
            try
            {
                return servicoTelefonesCliente.PesquisarTelefonesPorNumeroPersistence(numero);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<TelefonesCliente> PesquisarTelefonesPorTipoTelefoneService(TipoTelefones tipoTelefone)
        {
            try
            {
                return servicoTelefonesCliente.PesquisarTelefonesPorTipoTelefonePersistence(tipoTelefone);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}