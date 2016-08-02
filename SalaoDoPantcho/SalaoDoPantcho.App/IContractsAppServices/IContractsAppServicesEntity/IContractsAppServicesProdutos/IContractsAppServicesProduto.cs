using System;
using System.Collections.Generic;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesProdutos
{
    public interface IContractsAppServicesProduto : IContractsAppServicesBase<Produtos, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Produtos AppServicesPesquisarProdutoPorNome(string nome);
        ICollection<Produtos> AppServicesPesquisarProdutoPorFabricante(string fabricante);
        ICollection<Produtos> AppServicesPesquisarProdutoPorDataFabricante(DateTime dataFabricante);
        ICollection<Produtos> AppServicesPesquisarProdutoPorDataValidade(DateTime dataValidade);

        #endregion
    }
}