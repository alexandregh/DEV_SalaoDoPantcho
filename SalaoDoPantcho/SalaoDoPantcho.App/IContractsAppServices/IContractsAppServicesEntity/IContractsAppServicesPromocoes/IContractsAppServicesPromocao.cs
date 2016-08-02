using System;
using System.Collections.Generic;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesPromocoes
{
    public interface IContractsAppServicesPromocao : IContractsAppServicesBase<Promocoes, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Promocoes AppServicesPesquisarPromocaoPorNome(string nome);
        ICollection<Promocoes> AppServicesPesquisarPromocoesPorDataInicio(DateTime dataInicio);
        ICollection<Promocoes> AppServicesPesquisarPromocoesPorDataFim(DateTime dataFim);
        ICollection<Promocoes> AppServicesPesquisarPromocoesPorDataInicioFim(DateTime dataInicio, DateTime dataFim);

        #endregion
    }
}