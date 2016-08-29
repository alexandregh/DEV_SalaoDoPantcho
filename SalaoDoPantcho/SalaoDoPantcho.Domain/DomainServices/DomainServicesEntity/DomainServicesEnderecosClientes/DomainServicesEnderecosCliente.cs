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
            return servicoEnderecosCliente.PesquisarEnderecoPorTipoEnderecoPersistence(tipoEndereco);
        }

        public EnderecosCliente PesquisarEnderecoPorBairroService(string bairro)
        {            
            return servicoEnderecosCliente.PesquisarEnderecoPorBairroPersistence(bairro);
        }

        public EnderecosCliente PesquisarEnderecoPorCepService(string cep)
        {
            return servicoEnderecosCliente.PesquisarEnderecoPorCepPersistence(cep);
        }

        //__________

        public ICollection<EnderecosCliente> PesquisarEnderecosPorBairroService(string bairro)
        {            
            return servicoEnderecosCliente.PesquisarEnderecosPorBairroPersistence(bairro);
        }

        public ICollection<EnderecosCliente> PesquisarEnderecosPorCepService(string cep)
        {
            return servicoEnderecosCliente.PesquisarEnderecosPorCepPersistence(cep);
        }

        public ICollection<EnderecosCliente> PesquisarEnderecosPorTipoEnderecosService(TipoEnderecos tipoEndereco)
        {
            return servicoEnderecosCliente.PesquisarEnderecosPorTipoEnderecosPersistence(tipoEndereco);
        }

        #endregion
    }
}