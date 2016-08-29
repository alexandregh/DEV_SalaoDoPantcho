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
            if (!string.IsNullOrEmpty(descricao))
            {
                try
                {
                    DatasComemorativas datasComemorativasPorDescricao = dataContext.DatasComemorativas.AsParallel()
                                                                        .Where(data => data.Descricao == descricao)
                                                                        .FirstOrDefault();
                    if (datasComemorativasPorDescricao != null)
                    {
                        dataContext.Dispose();
                        return datasComemorativasPorDescricao;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return datasComemorativasPorDescricao;
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

        public DatasComemorativas PesquisarDatasComemorativasPorDescricaoEDataComemorativaPersistence(string descricao, DateTime dataComemorativa)
        {
            if (!string.IsNullOrEmpty(descricao) && dataComemorativa != null)
            {
                try
                {
                    DatasComemorativas datasComemorativasacessorioPorDescricao = dataContext.DatasComemorativas.AsParallel()
                                                                                 .Where(data => data.Descricao == descricao && data.DataComemorativa == dataComemorativa)
                                                                                 .FirstOrDefault();
                    if (datasComemorativasacessorioPorDescricao != null)
                    {
                        dataContext.Dispose();
                        return datasComemorativasacessorioPorDescricao;
                    }
                    else
                    {
                        dataContext.Dispose();
                        return datasComemorativasacessorioPorDescricao;
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