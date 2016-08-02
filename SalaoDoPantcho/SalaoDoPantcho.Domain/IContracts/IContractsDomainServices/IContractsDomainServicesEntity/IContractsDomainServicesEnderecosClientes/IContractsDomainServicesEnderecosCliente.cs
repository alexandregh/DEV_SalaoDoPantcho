using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEnderecosClientes
{
    public interface IContractsDomainServicesEnderecosCliente : IContractsDomainServicesBase<EnderecosCliente, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        EnderecosCliente PesquisarEnderecoPorTipoEnderecoService(TipoEnderecos tipoEndereco);
        EnderecosCliente PesquisarEnderecoPorBairroService(string bairro);
        EnderecosCliente PesquisarEnderecoPorCepService(string cep);

        //__________

        ICollection<EnderecosCliente> PesquisarEnderecosPorTipoEnderecosService(TipoEnderecos tipoEndereco);
        ICollection<EnderecosCliente> PesquisarEnderecosPorBairroService(string bairro);
        ICollection<EnderecosCliente> PesquisarEnderecosPorCepService(string cep);

        #endregion
    }
}