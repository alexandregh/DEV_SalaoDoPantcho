using System;
using SalaoDoPantcho.Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores;
using SalaoDoPantcho.SGBD.Repository.RepositoryBases;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Repository.RepositoryEntity.RepositoryAdministradores
{
    public class RepositoryAdministrador : RepositoryBase<Administradores, Int32>, IContractsSGBDAdministrador
    {
        #region Implementação Métodos Serviços

        public void VincularClienteAProdutosPersistence(string login, string email)
        {
            throw new NotImplementedException();
        }

        public void VincularClienteAPromocaoDatasComemorativasPersistence(string login, string email)
        {
            throw new NotImplementedException();
        }

        public void VincularClienteAPromocaoPersistence(string login, string email)
        {
            throw new NotImplementedException();
        }

        public void VincularClienteAServicoPersistence(string login, string email)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}