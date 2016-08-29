using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesPromocoes;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesPromocoes;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesPromocoes
{
    public class AppServicesPromocao : AppServicesBase<Promocoes, Int32>, IContractsAppServicesPromocao
    {
        #region Atributo

        private IContractsDomainServicesPromocao appServicesPromocao;

        #endregion

        #region Construtor

        public AppServicesPromocao(IContractsDomainServicesPromocao appServicesPromocao)
            : base(appServicesPromocao)
        {
            this.appServicesPromocao = appServicesPromocao;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public Promocoes AppServicesPesquisarPromocaoPorNome(string nome)
        {
            return appServicesPromocao.PesquisarPromocaoPorNomeService(nome);
        }

        public ICollection<Promocoes> AppServicesPesquisarPromocoesPorDataFim(DateTime dataFim)
        {
            return appServicesPromocao.PesquisarPromocoesPorDataFimService(dataFim);
        }

        public ICollection<Promocoes> AppServicesPesquisarPromocoesPorDataInicio(DateTime dataInicio)
        {
            return appServicesPromocao.PesquisarPromocoesPorDataInicioService(dataInicio);
        }

        public ICollection<Promocoes> AppServicesPesquisarPromocoesPorDataInicioFim(DateTime dataInicio, DateTime dataFim)
        {
            return appServicesPromocao.PesquisarPromocoesPorDataInicioFimService(dataInicio, dataFim);
        }

        #endregion
    }
}