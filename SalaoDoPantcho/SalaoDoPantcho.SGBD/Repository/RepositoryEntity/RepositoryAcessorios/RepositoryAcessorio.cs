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
            try
            {
                Acessorios acessorioPorNome = this.dataContext.Acessorios.AsNoTracking().Where(acessorio => acessorio.Nome == nome).FirstOrDefault();
                if (acessorioPorNome != null)
                {
                    this.dataContext.Dispose();
                    return acessorioPorNome;
                }
                else
                {
                    this.dataContext.Dispose();
                    return acessorioPorNome;
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