using System;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesDatasComemorativas
{
    public interface IContractsAppServicesDataComemorativa : IContractsAppServicesBase<DatasComemorativas, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        DatasComemorativas AppServicesPesquisarDatasComemorativasPorDescricao(string descricao);
        DatasComemorativas AppServicesPesquisarDatasComemorativasPorDescricaoEDataComemorativa(string descricao, DateTime dataComemorativa);

        #endregion
    }
}