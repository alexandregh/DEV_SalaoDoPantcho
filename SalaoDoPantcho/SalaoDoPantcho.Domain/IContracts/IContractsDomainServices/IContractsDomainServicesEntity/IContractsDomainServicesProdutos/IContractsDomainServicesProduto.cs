using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProdutos
{
    public interface IContractsDomainServicesProduto : IContractsDomainServicesBase<Produtos, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Produtos PesquisarProdutoPorNomeService(string nome);
        ICollection<Produtos> PesquisarProdutoPorFabricanteService(string fabricante);
        ICollection<Produtos> PesquisarProdutoPorDataFabricanteService(DateTime dataFabricante);
        ICollection<Produtos> PesquisarProdutoPorDataValidadeService(DateTime dataValidade);

        #endregion
    }
}