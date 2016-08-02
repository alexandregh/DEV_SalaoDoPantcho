using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDDatasComemorativas
{
    public interface IContractsSGBDDataComemorativa : IContractsSGBDBase<DatasComemorativas, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        DatasComemorativas PesquisarDatasComemorativasPorDescricaoPersistence(string descricao);
        DatasComemorativas PesquisarDatasComemorativasPorDescricaoEDataComemorativaPersistence(string descricao, DateTime dataComemorativa);

        #endregion
    }
}
