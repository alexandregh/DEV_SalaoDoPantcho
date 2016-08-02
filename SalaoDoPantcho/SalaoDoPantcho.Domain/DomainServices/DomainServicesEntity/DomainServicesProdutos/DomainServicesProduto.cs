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
            try
            {
                return servicoProduto.PesquisarProdutoPorDataFabricantePersistence(dataFabricante);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Produtos> PesquisarProdutoPorDataValidadeService(DateTime dataValidade)
        {
            try
            {
                return servicoProduto.PesquisarProdutoPorDataValidadePersistence(dataValidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Produtos> PesquisarProdutoPorFabricanteService(string fabricante)
        {
            try
            {
                return servicoProduto.PesquisarProdutoPorFabricantePersistence(fabricante);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produtos PesquisarProdutoPorNomeService(string nome)
        {
            try
            {
                return servicoProduto.PesquisarProdutoPorNomePercistence(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}