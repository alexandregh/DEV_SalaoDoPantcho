using System;
using System.Collections.Generic;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesTelefonesClientes
{
    public interface IContractsAppServicesTelefonesCliente : IContractsAppServicesBase<TelefonesCliente, Int32>
    {
        // métodos específicos...
        #region Pesquisa Específica

        TelefonesCliente AppServicesPesquisarTelefonePorDDD(byte ddd);
        TelefonesCliente AppServicesPesquisarTelefonePorNumero(int numero);
        TelefonesCliente AppServicesPesquisarTelefonePorTipoTelefone(TipoTelefones tipoTelefone);

        ICollection<TelefonesCliente> AppServicesPesquisarTelefonesPorDDD(byte ddd);
        ICollection<TelefonesCliente> AppServicesPesquisarTelefonesPorNumero(int numero);
        ICollection<TelefonesCliente> AppServicesPesquisarTelefonesPorTipoTelefone(TipoTelefones tipoTelefone);

        #endregion
    }
}