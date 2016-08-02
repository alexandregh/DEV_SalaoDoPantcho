using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEnderecosClientes
{
    public interface IContractsSGBDEnderecosCliente : IContractsSGBDBase<EnderecosCliente, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        EnderecosCliente PesquisarEnderecoPorTipoEnderecoPersistence(TipoEnderecos tipoEndereco);
        EnderecosCliente PesquisarEnderecoPorBairroPersistence(string bairro);
        EnderecosCliente PesquisarEnderecoPorCepPersistence(string cep);

        //_________

        ICollection<EnderecosCliente> PesquisarEnderecosPorTipoEnderecosPersistence(TipoEnderecos tipoEndereco);
        ICollection<EnderecosCliente> PesquisarEnderecosPorBairroPersistence(string bairro);
        ICollection<EnderecosCliente> PesquisarEnderecosPorCepPersistence(string cep);

        #endregion
    }
}