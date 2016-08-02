using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProdutos;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesProdutos;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesProdutos
{
    public class AppServicesProduto : AppServicesBase<Produtos, Int32>, IContractsAppServicesProduto
    {
        #region Atributo

        private IContractsDomainServicesProduto appServicesProduto;

        #endregion

        #region Construtor

        public AppServicesProduto(IContractsDomainServicesProduto appServicesProduto)
            : base(appServicesProduto)
        {
            this.appServicesProduto = appServicesProduto;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public ICollection<Produtos> AppServicesPesquisarProdutoPorDataFabricante(DateTime dataFabricante)
        {
            return this.appServicesProduto.PesquisarProdutoPorDataFabricanteService(dataFabricante);
        }

        public ICollection<Produtos> AppServicesPesquisarProdutoPorDataValidade(DateTime dataValidade)
        {
            return this.appServicesProduto.PesquisarProdutoPorDataValidadeService(dataValidade);
        }

        public ICollection<Produtos> AppServicesPesquisarProdutoPorFabricante(string fabricante)
        {
            return this.appServicesProduto.PesquisarProdutoPorFabricanteService(fabricante);
        }

        public Produtos AppServicesPesquisarProdutoPorNome(string nome)
        {
            return this.appServicesProduto.PesquisarProdutoPorNomeService(nome);
        }

        #endregion
    }
}