using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesPromocoes;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDPromocoes;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesPromocoes
{
    public class DomainServicesPromocao : DomainServicesBase<Promocoes, Int32>, IContractsDomainServicesPromocao
    {
        #region Atributo

        private IContractsSGBDPromocao servicoPromocao;

        #endregion

        #region Construtor

        public DomainServicesPromocao(IContractsSGBDPromocao servicoPromocao)
            : base(servicoPromocao)
        {
            this.servicoPromocao = servicoPromocao;
        }

        #endregion

        #region Implementação Métodos Serviços

        public Promocoes PesquisarPromocaoPorNomeService(string nome)
        {            
            return servicoPromocao.PesquisarPromocaoPorNomePersistence(nome);
        }

        public ICollection<Promocoes> PesquisarPromocoesPorDataFimService(DateTime dataFim)
        {
            return servicoPromocao.PesquisarPromocoesPorDataFimPersistence(dataFim);
        }

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioFimService(DateTime dataInicio, DateTime dataFim)
        {            
            return servicoPromocao.PesquisarPromocoesPorDataInicioFimPersistence(dataInicio, dataFim);            
        }

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioService(DateTime dataInicio)
        {
            return servicoPromocao.PesquisarPromocoesPorDataInicioPersistence(dataInicio);
        }

        #endregion
    }
}