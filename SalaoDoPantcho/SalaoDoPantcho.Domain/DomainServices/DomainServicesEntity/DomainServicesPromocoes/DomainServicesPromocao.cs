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
            try
            {
                return servicoPromocao.PesquisarPromocaoPorNomePersistence(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Promocoes> PesquisarPromocoesPorDataFimService(DateTime dataFim)
        {
            try
            {
                return servicoPromocao.PesquisarPromocoesPorDataFimPersistence(dataFim);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioFimService(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                return servicoPromocao.PesquisarPromocoesPorDataInicioFimPersistence(dataInicio, dataFim);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Promocoes> PesquisarPromocoesPorDataInicioService(DateTime dataInicio)
        {
            try
            {
                return servicoPromocao.PesquisarPromocoesPorDataInicioPersistence(dataInicio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}