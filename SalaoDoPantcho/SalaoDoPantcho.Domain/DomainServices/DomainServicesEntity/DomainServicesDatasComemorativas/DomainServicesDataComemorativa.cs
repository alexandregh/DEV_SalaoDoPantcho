using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesDatasComemorativas;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDDatasComemorativas;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesDatasComemorativas
{
    public class DomainServicesDataComemorativa : DomainServicesBase<DatasComemorativas, Int32>, IContractsDomainServicesDataComemorativa
    {
        #region Atributo

        private IContractsSGBDDataComemorativa servicoDataComemorativa;

        #endregion

        #region Construtor

        public DomainServicesDataComemorativa(IContractsSGBDDataComemorativa servicoDataComemorativa)
            : base(servicoDataComemorativa)
        {
            this.servicoDataComemorativa = servicoDataComemorativa;
        }

        #endregion

        #region Implementação Métodos Serviços

        public DatasComemorativas PesquisarDatasComemorativasPorDescricaoService(string descricao)
        {
            return servicoDataComemorativa.PesquisarDatasComemorativasPorDescricaoPersistence(descricao);
        }

        public DatasComemorativas PesquisarDatasComemorativasPorDescricaoEDataComemorativaService(string descricao, DateTime dataComemorativa)
        {
            return servicoDataComemorativa.PesquisarDatasComemorativasPorDescricaoEDataComemorativaPersistence(descricao, dataComemorativa);
        }

        #endregion
    }
}