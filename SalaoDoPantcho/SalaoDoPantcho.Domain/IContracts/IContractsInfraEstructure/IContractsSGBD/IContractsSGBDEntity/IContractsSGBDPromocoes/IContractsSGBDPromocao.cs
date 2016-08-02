using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDPromocoes
{
    public interface IContractsSGBDPromocao : IContractsSGBDBase<Promocoes, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Promocoes PesquisarPromocaoPorNomePersistence(string nome);
        ICollection<Promocoes> PesquisarPromocoesPorDataInicioPersistence(DateTime dataInicio);
        ICollection<Promocoes> PesquisarPromocoesPorDataFimPersistence(DateTime dataFim);
        ICollection<Promocoes> PesquisarPromocoesPorDataInicioFimPersistence(DateTime dataInicio, DateTime dataFim);

        #endregion
    }
}