using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEnderecosClientes;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEnderecosClientes;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesEnderecos
{
    public class AppServicesEnderecosCliente : AppServicesBase<EnderecosCliente, Int32>, IContractsAppServicesEnderecosCliente
    {
        #region Atributo

        private IContractsDomainServicesEnderecosCliente appServicesEnderecosCliente;

        #endregion

        #region Construtor

        public AppServicesEnderecosCliente(IContractsDomainServicesEnderecosCliente appServicesEnderecosCliente)
            : base(appServicesEnderecosCliente)
        {
            this.appServicesEnderecosCliente = appServicesEnderecosCliente;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public EnderecosCliente AppServicePesquisarEnderecoPorTipoEndereco(TipoEnderecos tipoEndereco)
        {
            return appServicesEnderecosCliente.PesquisarEnderecoPorTipoEnderecoService(tipoEndereco);
        }

        public EnderecosCliente AppServicePesquisarEnderecoPorBairro(string bairro)
        {
            return appServicesEnderecosCliente.PesquisarEnderecoPorBairroService(bairro);
        }

        public EnderecosCliente AppServicePesquisarEnderecoPorCep(string cep)
        {
            return appServicesEnderecosCliente.PesquisarEnderecoPorCepService(cep);
        }

        //__________

        public ICollection<EnderecosCliente> AppServicesPesquisarEnderecosPorBairro(string bairro)
        {
            return appServicesEnderecosCliente.PesquisarEnderecosPorBairroService(bairro);
        }

        public ICollection<EnderecosCliente> AppServicesPesquisarEnderecosPorCep(string cep)
        {
            return appServicesEnderecosCliente.PesquisarEnderecosPorCepService(cep);
        }

        public ICollection<EnderecosCliente> AppServicesPesquisarEnderecosPorTipoEnderecos(TipoEnderecos tipoEndereco)
        {
            return appServicesEnderecosCliente.PesquisarEnderecosPorTipoEnderecosService(tipoEndereco);
        }

        #endregion
    }
}