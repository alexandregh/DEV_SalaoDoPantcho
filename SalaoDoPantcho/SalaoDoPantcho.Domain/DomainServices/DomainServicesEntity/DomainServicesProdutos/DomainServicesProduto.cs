using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProdutos;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDProdutos;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesProdutos
{
    public class DomainServicesProduto : DomainServicesBase<Produtos, Int32>, IContractsDomainServicesProduto
    {
        #region Atributo

        private IContractsSGBDProduto servicoProduto;

        #endregion

        #region Construtor

        public DomainServicesProduto(IContractsSGBDProduto servicoProduto)
            : base(servicoProduto)
        {
            this.servicoProduto = servicoProduto;
        }

        #endregion

        #region Implementação Métodos Serviços

        public ICollection<Produtos> PesquisarProdutoPorDataFabricanteService(DateTime dataFabricante)
        {
            return servicoProduto.PesquisarProdutoPorDataFabricantePersistence(dataFabricante);
        }

        public ICollection<Produtos> PesquisarProdutoPorDataValidadeService(DateTime dataValidade)
        {
            return servicoProduto.PesquisarProdutoPorDataValidadePersistence(dataValidade);
        }

        public ICollection<Produtos> PesquisarProdutoPorFabricanteService(string fabricante)
        {
            return servicoProduto.PesquisarProdutoPorFabricantePersistence(fabricante);
        }

        public Produtos PesquisarProdutoPorNomeService(string nome)
        {
            return servicoProduto.PesquisarProdutoPorNomePercistence(nome);
        }

        #endregion
    }
}