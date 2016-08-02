using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDServicos
{
    public interface IContractsSGBDServico : IContractsSGBDBase<Servicos, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Servicos PesquisarServicosPorNomePersistence(string nome);
        ICollection<Servicos> PesquisarServicosPorPrecoPersistence(decimal preco);
        ICollection<Servicos> PesquisarServicosPorGeneroPersistence(GeneroServico generoServico);

        #endregion
    }
}