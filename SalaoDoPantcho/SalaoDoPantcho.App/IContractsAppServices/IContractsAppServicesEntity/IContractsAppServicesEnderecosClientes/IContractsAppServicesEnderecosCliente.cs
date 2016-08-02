using System;
using System.Collections.Generic;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEnderecosClientes
{
    public interface IContractsAppServicesEnderecosCliente : IContractsAppServicesBase<EnderecosCliente, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        EnderecosCliente AppServicePesquisarEnderecoPorTipoEndereco(TipoEnderecos tipoEndereco);
        EnderecosCliente AppServicePesquisarEnderecoPorBairro(string bairro);
        EnderecosCliente AppServicePesquisarEnderecoPorCep(string cep);

        //___________

        ICollection<EnderecosCliente> AppServicesPesquisarEnderecosPorTipoEnderecos(TipoEnderecos tipoEndereco);
        ICollection<EnderecosCliente> AppServicesPesquisarEnderecosPorBairro(string bairro);
        ICollection<EnderecosCliente> AppServicesPesquisarEnderecosPorCep(string cep);

        #endregion
    }
}