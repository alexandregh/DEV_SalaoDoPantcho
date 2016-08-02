using System;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAcessorios;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAcessorios;
using SalaoDoPantcho.Domain.DomainServices.DomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.DomainServices.DomainServicesEntity.DomainServicesAcessorios
{
    public class DomainServicesAcessorio : DomainServicesBase<Acessorios, Int32>, IContractsDomainServicesAcessorio
    {
        #region Atributo

        private IContractsSGBDAcessorio servicoAcessorio;

        #endregion

        #region Construtor

        public DomainServicesAcessorio(IContractsSGBDAcessorio servicoAcessorio)
            : base(servicoAcessorio)
        {
            this.servicoAcessorio = servicoAcessorio;
        }

        #endregion

        #region Implementação Métodos Serviços

        public Acessorios PesquisarAcessorioPorNomeService(string nome)
        {
            try
            {
                return servicoAcessorio.PesquisarAcessorioPorNomePersistence(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}