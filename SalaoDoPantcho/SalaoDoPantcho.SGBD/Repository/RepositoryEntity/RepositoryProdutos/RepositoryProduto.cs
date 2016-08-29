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
            if (dataFabricante != null)
            {
                try
                {
                    List<Produtos> produtoPorDataFabricante = dataContext.Produtos.AsParallel()
                                                              .Where(produto => produto.DataFabricacao == dataFabricante)
                                                              .ToList();
                    if (produtoPorDataFabricante != null)
                    {
                        dataContext.Dispose();
                        return produtoPorDataFabricante;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        public ICollection<Produtos> PesquisarProdutoPorDataValidadePersistence(DateTime dataValidade)
        {
            if (dataValidade != null)
            {
                try
                {
                    List<Produtos> produtoPorDataValidade = dataContext.Produtos.AsParallel()
                                                            .Where(produto => produto.DataValidade == dataValidade)
                                                            .ToList();
                    if (produtoPorDataValidade != null)
                    {
                        dataContext.Dispose();
                        return produtoPorDataValidade;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        public ICollection<Produtos> PesquisarProdutoPorFabricantePersistence(string fabricante)
        {
            if (!string.IsNullOrEmpty(fabricante))
            {
                try
                {
                    List<Produtos> produtoPorFabricante = dataContext.Produtos.AsParallel()
                                                          .Where(produto => produto.Fabricante == fabricante)
                                                          .ToList();
                    if (produtoPorFabricante != null)
                    {
                        dataContext.Dispose();
                        return produtoPorFabricante;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
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
            else
            {
                return null;
            }
        }

        public Produtos PesquisarProdutoPorNomePercistence(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    Produtos produtoPorNome = dataContext.Produtos.AsParallel()
                                              .Where(produto => produto.Nome == nome)
                                              .FirstOrDefault();
                    if (produtoPorNome != null)
                    {
                        dataContext.Dispose();
                        return produtoPorNome;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return null;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}