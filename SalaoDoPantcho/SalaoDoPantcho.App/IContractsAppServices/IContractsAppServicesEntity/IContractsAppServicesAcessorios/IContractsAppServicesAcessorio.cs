using System;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAcessorios
{
    public interface IContractsAppServicesAcessorio : IContractsAppServicesBase<Acessorios, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Acessorios AppServicesPesquisarAcessorioPorNome(string nome);

        #endregion
    }
}