using System;
using System.Collections.Generic;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDProdutos;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;


namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryProdutos
{
    public class RepositoryProduto : RepositoryBase<Produtos, Int32>, IContractsSGBDProduto
    {
        #region Implementação Métodos Persistentes

        public ICollection<Produtos> PesquisarProdutoPorDataFabricantePersistence(DateTime dataFabricante)
        {
            try
            {
                List<Produtos> produtoPorDataFabricante = this.dataContext.Produtos.AsNoTracking().Where(produto => produto.DataFabricacao == dataFabricante).ToList();
                if (produtoPorDataFabricante != null)
                {
                    this.dataContext.Dispose();
                    return produtoPorDataFabricante;
                }
                else
                {
                    this.dataContext.Dispose();
                    return produtoPorDataFabricante;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public ICollection<Produtos> PesquisarProdutoPorDataValidadePersistence(DateTime dataValidade)
        {
            try
            {
                List<Produtos> produtoPorDataValidade = this.dataContext.Produtos.AsNoTracking().Where(produto => produto.DataValidade == dataValidade).ToList();
                if (produtoPorDataValidade != null)
                {
                    this.dataContext.Dispose();
                    return produtoPorDataValidade;
                }
                else
                {
                    this.dataContext.Dispose();
                    return produtoPorDataValidade;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public ICollection<Produtos> PesquisarProdutoPorFabricantePersistence(string fabricante)
        {
            try
            {
                List<Produtos> produtoPorFabricante = this.dataContext.Produtos.AsNoTracking().Where(produto => produto.Fabricante == fabricante).ToList();
                if (produtoPorFabricante != null)
                {
                    this.dataContext.Dispose();
                    return produtoPorFabricante;
                }
                else
                {
                    this.dataContext.Dispose();
                    return produtoPorFabricante;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        public Produtos PesquisarProdutoPorNomePercistence(string nome)
        {
            try
            {
                Produtos produtoPorNome = this.dataContext.Produtos.AsNoTracking().Where(produto => produto.Nome == nome).FirstOrDefault();
                if (produtoPorNome != null)
                {
                    this.dataContext.Dispose();
                    return produtoPorNome;
                }
                else
                {
                    this.dataContext.Dispose();
                    return produtoPorNome;
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Ocorreu o erro: " + ex.Message + ". Aguarde alguns instantes e tente novamente.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro desconhecido: " + ex.Message + ". Aguarde alguns instantes e tente novamente ou contate o Suporte do Sistema.");
            }
        }

        #endregion
    }
}