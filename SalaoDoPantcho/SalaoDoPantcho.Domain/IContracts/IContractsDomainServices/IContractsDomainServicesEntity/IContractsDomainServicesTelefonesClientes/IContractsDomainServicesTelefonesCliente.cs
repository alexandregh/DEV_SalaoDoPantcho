using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesTelefonesClientes
{
    public interface IContractsDomainServicesTelefonesCliente : IContractsDomainServicesBase<TelefonesCliente, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        TelefonesCliente PesquisarTelefonePorDDDService(byte ddd);
        TelefonesCliente PesquisarTelefonePorNumeroService(int numero);
        TelefonesCliente PesquisarTelefonePorTipoTelefoneService(TipoTelefones tipoTelefone);

        ICollection<TelefonesCliente> PesquisarTelefonesPorDDDService(byte ddd);
        ICollection<TelefonesCliente> PesquisarTelefonesPorNumeroService(int numero);
        ICollection<TelefonesCliente> PesquisarTelefonesPorTipoTelefoneService(TipoTelefones tipoTelefone);

        #endregion
    }
}