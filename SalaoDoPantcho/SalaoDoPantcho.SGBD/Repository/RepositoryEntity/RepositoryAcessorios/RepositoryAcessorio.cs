using System;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAcessorios;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryAcessorios
{
    public class RepositoryAcessorio : RepositoryBase<Acessorios, Int32>, IContractsSGBDAcessorio
    {
        #region Implementação Métodos Persistentes

        public Acessorios PesquisarAcessorioPorNomePersistence(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    Acessorios acessorioPorNome = dataContext.Acessorios.AsParallel()
                                                  .Where(acessorio => acessorio.Nome == nome)
                                                  .FirstOrDefault();
                    if (acessorioPorNome != null)
                    {
                        dataContext.Dispose();
                        return acessorioPorNome;
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