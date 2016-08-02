using System;
using System.Linq;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDDatasComemorativas;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryDatasComemorativas
{
    public class RepositoryDataComemorativa : RepositoryBase<DatasComemorativas, Int32>, IContractsSGBDDataComemorativa
    {
        #region Implementação Métodos Persistentes

        public DatasComemorativas PesquisarDatasComemorativasPorDescricaoPersistence(string descricao)
        {
            try
            {
                DatasComemorativas datasComemorativasPorDescricao = this.dataContext.DatasComemorativas.AsNoTracking().Where(data => data.Descricao == descricao).FirstOrDefault();
                if (datasComemorativasPorDescricao != null)
                {
                    this.dataContext.Dispose();
                    return datasComemorativasPorDescricao;
                }
                else
                {
                    this.dataContext.Dispose();
                    return datasComemorativasPorDescricao;
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

        public DatasComemorativas PesquisarDatasComemorativasPorDescricaoEDataComemorativaPersistence(string descricao, DateTime dataComemorativa)
        {
            try
            {
                DatasComemorativas datasComemorativasacessorioPorDescricao = this.dataContext.DatasComemorativas.AsNoTracking()
                                                                             .Where(data => data.Descricao == descricao && data.DataComemorativa == dataComemorativa)
                                                                             .FirstOrDefault();
                if (datasComemorativasacessorioPorDescricao != null)
                {
                    this.dataContext.Dispose();
                    return datasComemorativasacessorioPorDescricao;
                }
                else
                {
                    this.dataContext.Dispose();
                    return datasComemorativasacessorioPorDescricao;
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