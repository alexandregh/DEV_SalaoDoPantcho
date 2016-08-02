using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDProdutos
{
    public interface IContractsSGBDProduto : IContractsSGBDBase<Produtos, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        Produtos PesquisarProdutoPorNomePercistence(string nome);
        ICollection<Produtos> PesquisarProdutoPorFabricantePersistence(string fabricante);
        ICollection<Produtos> PesquisarProdutoPorDataFabricantePersistence(DateTime dataFabricante);
        ICollection<Produtos> PesquisarProdutoPorDataValidadePersistence(DateTime dataValidade);

        #endregion
    }
}