using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDTelefonesClientes
{
    public interface IContractsSGBDTelefonesCliente : IContractsSGBDBase<TelefonesCliente, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        TelefonesCliente PesquisarTelefonePorDDDPersistence(byte ddd);
        TelefonesCliente PesquisarTelefonePorNumeroPersistence(int numero);
        TelefonesCliente PesquisarTelefonePorTipoTelefonePersistence(TipoTelefones tipoTelefone);

        ICollection<TelefonesCliente> PesquisarTelefonesPorDDDPersistence(byte ddd);
        ICollection<TelefonesCliente> PesquisarTelefonesPorNumeroPersistence(int numero);
        ICollection<TelefonesCliente> PesquisarTelefonesPorTipoTelefonePersistence(TipoTelefones tipoTelefone);

        #endregion
    }
}