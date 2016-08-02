using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEnderecosClientes;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEnderecosClientes;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesEnderecosCliente
{
    public class DomainServicesEnderecosCliente : DomainServicesBase<EnderecosCliente, Int32>, IContractsDomainServicesEnderecosCliente
    {
        #region Atributo

        private IContractsSGBDEnderecosCliente servicoEnderecosCliente;

        #endregion

        #region Construtor

        public DomainServicesEnderecosCliente(IContractsSGBDEnderecosCliente servicoEnderecosCliente)
            : base(servicoEnderecosCliente)
        {
            this.servicoEnderecosCliente = servicoEnderecosCliente;
        }

        #endregion

        #region Implementação Métodos Serviços

        public EnderecosCliente PesquisarEnderecoPorTipoEnderecoService(TipoEnderecos tipoEndereco)
        {
            try
            {
                return servicoEnderecosCliente.PesquisarEnderecoPorTipoEnderecoPersistence(tipoEndereco);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EnderecosCliente PesquisarEnderecoPorBairroService(string bairro)
        {
            try
            {
                return servicoEnderecosCliente.PesquisarEnderecoPorBairroPersistence(bairro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EnderecosCliente PesquisarEnderecoPorCepService(string cep)
        {
            try
            {
                return servicoEnderecosCliente.PesquisarEnderecoPorCepPersistence(cep);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //__________

        public ICollection<EnderecosCliente> PesquisarEnderecosPorBairroService(string bairro)
        {
            try
            {
                return servicoEnderecosCliente.PesquisarEnderecosPorBairroPersistence(bairro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<EnderecosCliente> PesquisarEnderecosPorCepService(string cep)
        {
            try
            {
                return servicoEnderecosCliente.PesquisarEnderecosPorCepPersistence(cep);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<EnderecosCliente> PesquisarEnderecosPorTipoEnderecosService(TipoEnderecos tipoEndereco)
        {
            try
            {
                return servicoEnderecosCliente.PesquisarEnderecosPorTipoEnderecosPersistence(tipoEndereco);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}