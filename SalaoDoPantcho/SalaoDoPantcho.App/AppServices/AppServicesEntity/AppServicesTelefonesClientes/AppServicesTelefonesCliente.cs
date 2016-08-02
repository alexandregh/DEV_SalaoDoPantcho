using System;
using System.Collections.Generic;
using SalaoDoPantcho.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesTelefonesClientes;
using SalaoDoPantcho.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesTelefonesClientes;
using SalaoDoPantcho.App.AppServices.AppServicesBases;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.App.AppServices.AppServicesEntity.AppServicesTelefones
{
    public class AppServicesTelefoneCliente : AppServicesBase<TelefonesCliente, Int32>, IContractsAppServicesTelefonesCliente
    {
        #region Atributo

        private IContractsDomainServicesTelefonesCliente appServicesTelefonesCliente;

        #endregion

        #region Construtor

        public AppServicesTelefoneCliente(IContractsDomainServicesTelefonesCliente appServicesTelefonesCliente)
            : base(appServicesTelefonesCliente)
        {
            this.appServicesTelefonesCliente = appServicesTelefonesCliente;
        }

        #endregion

        #region Implementação Métodos Aplicação

        public TelefonesCliente AppServicesPesquisarTelefonePorDDD(byte ddd)
        {
            return appServicesTelefonesCliente.PesquisarTelefonePorDDDService(ddd);
        }

        public TelefonesCliente AppServicesPesquisarTelefonePorNumero(int numero)
        {
            return appServicesTelefonesCliente.PesquisarTelefonePorNumeroService(numero);
        }

        public TelefonesCliente AppServicesPesquisarTelefonePorTipoTelefone(TipoTelefones tipoTelefone)
        {
            return appServicesTelefonesCliente.PesquisarTelefonePorTipoTelefoneService(tipoTelefone);
        }

        public TelefonesCliente AppServicesPesquisarTelefonesPorNumero(int numero)
        {
            return appServicesTelefonesCliente.PesquisarTelefonePorNumeroService(numero);
        }

        public ICollection<TelefonesCliente> AppServicesPesquisarTelefonesPorDDD(byte ddd)
        {
            return appServicesTelefonesCliente.PesquisarTelefonesPorDDDService(ddd);
        }

        ICollection<TelefonesCliente> IContractsAppServicesTelefonesCliente.AppServicesPesquisarTelefonesPorNumero(int numero)
        {
            return appServicesTelefonesCliente.PesquisarTelefonesPorNumeroService(numero);
        }

        public ICollection<TelefonesCliente> AppServicesPesquisarTelefonesPorTipoTelefone(TipoTelefones tipoTelefone)
        {
            return appServicesTelefonesCliente.PesquisarTelefonesPorTipoTelefoneService(tipoTelefone);
        }

        #endregion
    }
}