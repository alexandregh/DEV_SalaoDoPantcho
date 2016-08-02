using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores
{
    public interface IContractsSGBDAdministrador : IContractsSGBDBase<Administradores, Int32>
    {
        // métodos específicos...
        #region Serviços

        void VincularClienteAPromocaoPersistence(string login, string email);
        void VincularClienteAPromocaoDatasComemorativasPersistence(string login, string email);
        void VincularClienteAProdutosPersistence(string login, string email);
        void VincularClienteAServicoPersistence(string login, string email);

        #endregion
    }
}