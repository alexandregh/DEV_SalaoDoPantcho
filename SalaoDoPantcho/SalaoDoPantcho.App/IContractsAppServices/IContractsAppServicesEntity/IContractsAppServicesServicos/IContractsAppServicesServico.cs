using System;
using System.Collections.Generic;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesServicos
{
    public interface IContractsAppServicesServico : IContractsAppServicesBase<Servicos, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Servicos AppServicesPesquisarServicosPorNome(string nome);
        ICollection<Servicos> AppServicesPesquisarServicosPorPreco(decimal preco);
        ICollection<Servicos> AppServicesPesquisarServicosPorGenero(GeneroServico generoServico);

        #endregion
    }
}