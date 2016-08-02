using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAcessorios
{
    public interface IContractsSGBDAcessorio : IContractsSGBDBase<Acessorios, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Acessorios PesquisarAcessorioPorNomePersistence(string nome);

        #endregion
    }
}