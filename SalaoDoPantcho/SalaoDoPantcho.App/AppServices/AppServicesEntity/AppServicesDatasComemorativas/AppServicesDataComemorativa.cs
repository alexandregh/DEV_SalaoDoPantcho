using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesDatasComemorativas;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesDatasComemorativas;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesDatasComemorativas
{
    public class AppServicesDataComemorativa : AppServicesBase<DatasComemorativas, Int32>, IContractsAppServicesDataComemorativa
    {
        #region Atributo

        private IContractsDomainServicesDataComemorativa appServicesDatasComemorativas;

        #endregion

        #region Construtor

        public AppServicesDataComemorativa(IContractsDomainServicesDataComemorativa appServicesDatasComemorativas)
            : base(appServicesDatasComemorativas)
        {
            this.appServicesDatasComemorativas = appServicesDatasComemorativas;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public DatasComemorativas AppServicesPesquisarDatasComemorativasPorDescricao(string descricao)
        {
            return this.appServicesDatasComemorativas.PesquisarDatasComemorativasPorDescricaoService(descricao);
        }

        public DatasComemorativas AppServicesPesquisarDatasComemorativasPorDescricaoEDataComemorativa(string descricao, DateTime dataComemorativa)
        {
            return this.appServicesDatasComemorativas.PesquisarDatasComemorativasPorDescricaoEDataComemorativaService(descricao, dataComemorativa);
        }

        #endregion
    }
}