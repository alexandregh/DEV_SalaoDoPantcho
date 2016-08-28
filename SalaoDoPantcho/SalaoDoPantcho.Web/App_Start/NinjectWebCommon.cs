[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SalaoDoPantcho.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SalaoDoPantcho.Web.App_Start.NinjectWebCommon), "Stop")]

namespace SalaoDoPantcho.Web.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    using App.IContractsAppServices.IContractsAppServicesBases;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAcessorios;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAdministradores;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesClientes;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesDatasComemorativas;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEnderecosClientes;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEnderecosAdministradores;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesProdutos;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesPromocoes;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesServicos;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesTelefonesClientes;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesTelefonesAdministradores;

    //_______

    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAcessorios;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesClientes;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesDatasComemorativas;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEnderecosClientes;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEnderecosAdministradores;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProdutos;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesPromocoes;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesServicos;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesTelefonesClientes;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesTelefonesAdministradores;

    //_______

    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDBases;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAcessorios;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDClientes;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDDatasComemorativas;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEnderecosClientes;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEnderecosAdministradores;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDProdutos;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDPromocoes;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDServicos;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDTelefonesClientes;
    using Domain.IContracts.IContractsInfraEstructure.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDTelefonesAdministradores;

    //_______

    using App.AppServices.AppServicesBases;
    using App.AppServices.AppServicesEntity.AppServicesAcessorios;
    using App.AppServices.AppServicesEntity.AppServicesAdministradores;
    using App.AppServices.AppServicesEntity.AppServicesClientes;
    using App.AppServices.AppServicesEntity.AppServicesDatasComemorativas;
    using App.AppServices.AppServicesEntity.AppServicesEnderecos;
    using App.AppServices.AppServicesEntity.AppServicesProdutos;
    using App.AppServices.AppServicesEntity.AppServicesPromocoes;
    using App.AppServices.AppServicesEntity.AppServicesServicos;
    using App.AppServices.AppServicesEntity.AppServicesTelefones;

    //_______

    using Domain.DomainServices.DomainServicesBases;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesAcessorios;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesAdminitradores;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesClientes;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesDatasComemorativas;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesEnderecosCliente;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesProdutos;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesPromocoes;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesServicos;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesTelefonesClientes;

    //_______

    using SGBD.Repository.RepositoryBases;
    using SGBD.Repository.RepositoryEntity.RepositoryAcessorios;
    using SGBD.Repository.RepositoryEntity.RepositoryAdministradores;
    using SGBD.Repository.RepositoryEntity.RepositoryClientes;
    using SGBD.Repository.RepositoryEntity.RepositoryDatasComemorativas;
    using SGBD.Repository.RepositoryEntity.RepositoryEnderecosClientes;
    using SGBD.Repository.RepositoryEntity.RepositoryEnderecosAdministradores;
    using SGBD.Repository.RepositoryEntity.RepositoryProdutos;
    using SGBD.Repository.RepositoryEntity.RepositoryPromocoes;
    using SGBD.Repository.RepositoryEntity.RepositoryServicos;
    using SGBD.Repository.RepositoryEntity.RepositoryTelefonesClientes;
    using SGBD.Repository.RepositoryEntity.RepositoryTelefonesAdministradores;
    using App.AppServices.AppServicesEntity.AppServicesTelefonesAdministradores;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesEnderecosAdministradores;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesTelefonesAdministradores;
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                
                GlobalConfiguration.Configuration.
                DependencyResolver = kernel.Get
                <System.Web.Http.Dependencies.
                IDependencyResolver>();


                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //registrar os serviços..
            //registrar as dependencias..
            //nivel da aplicação..
            kernel.Bind(typeof(IContractsAppServicesBase<,>)).To(typeof(AppServicesBase<,>));
            kernel.Bind<IContractsAppServicesAcessorio>().To<AppServicesAcessorio>();
            kernel.Bind<IContractsAppServicesAdministrador>().To<AppServicesAdministrador>();
            kernel.Bind<IContractsAppServicesCliente>().To<AppServicesCliente>();
            kernel.Bind<IContractsAppServicesDataComemorativa>().To<AppServicesDataComemorativa>();
            kernel.Bind<IContractsAppServicesEnderecosCliente>().To<AppServicesEnderecosCliente>();
            kernel.Bind<IContractsAppServicesProduto>().To<AppServicesProduto>();
            kernel.Bind<IContractsAppServicesPromocao>().To<AppServicesPromocao>();
            kernel.Bind<IContractsAppServicesServico>().To<AppServicesServico>();
            kernel.Bind<IContractsAppServicesTelefonesCliente>().To<AppServicesTelefoneCliente>();
            kernel.Bind<IContractsAppServicesTelefonesAdministrador>().To<AppServicesTelefonesAdministrador>();

            //nivel do dominio..
            kernel.Bind(typeof(IContractsDomainServicesBase<,>)).To(typeof(DomainServicesBase<,>));
            kernel.Bind<IContractsDomainServicesAcessorio>().To<DomainServicesAcessorio>();
            kernel.Bind<IContractsDomainServicesAdministrador>().To<DomainServicesAdminitrador>();
            kernel.Bind<IContractsDomainServicesCliente>().To<DomainServicesCliente>();
            kernel.Bind<IContractsDomainServicesDataComemorativa>().To<DomainServicesDataComemorativa>();
            kernel.Bind<IContractsDomainServicesEnderecosCliente>().To<DomainServicesEnderecosCliente>();
            kernel.Bind<IContractsDomainServicesEnderecosAdministrador>().To<DomainServicesEnderecosAdministrador>();
            kernel.Bind<IContractsDomainServicesProduto>().To<DomainServicesProduto>();
            kernel.Bind<IContractsDomainServicesPromocao>().To<DomainServicesPromocao>();
            kernel.Bind<IContractsDomainServicesServico>().To<DomainServicesServico>();
            kernel.Bind<IContractsDomainServicesTelefonesCliente>().To<DomainServicesTelefonesCliente>();
            kernel.Bind<IContractsDomainServicesTelefonesAdministrador>().To<DomainServicesTelefonesAdministrador>();

            //nivel do repositorio..
            kernel.Bind(typeof(IContractsSGBDBase<,>)).To(typeof(RepositoryBase<,>));
            kernel.Bind<IContractsSGBDAcessorio>().To<RepositoryAcessorio>();
            kernel.Bind<IContractsSGBDAdministrador>().To<RepositoryAdministrador>();
            kernel.Bind<IContractsSGBDCliente>().To<RepositoryCliente>();
            kernel.Bind<IContractsSGBDDataComemorativa>().To<RepositoryDataComemorativa>();
            kernel.Bind<IContractsSGBDEnderecosCliente>().To<RepositoryEnderecosCliente>();
            kernel.Bind<IContractsSGBDEnderecosAdministrador>().To<RepositoryEnderecosAdministrador>();
            kernel.Bind<IContractsSGBDProduto>().To<RepositoryProduto>();
            kernel.Bind<IContractsSGBDPromocao>().To<RepositoryPromocao>();
            kernel.Bind<IContractsSGBDServico>().To<RepositoryServico>();
            kernel.Bind<IContractsSGBDTelefonesCliente>().To<RepositoryTelefoneCliente>();
            //kernel.Bind<IContractsSGBDTelefonesAdministrador>().To<RepositoryTelefonesAdministrador>();

        }
    }
}
