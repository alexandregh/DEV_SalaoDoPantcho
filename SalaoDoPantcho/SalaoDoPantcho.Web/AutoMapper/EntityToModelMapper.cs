using AutoMapper;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Web.Areas.Cliente.Models;
using SalaoDoPantcho.Web.Models.Sistema.Acessorios;
using SalaoDoPantcho.Web.Models.Sistema.Administrador;
using SalaoDoPantcho.Web.Models.Sistema.Clientes;
using SalaoDoPantcho.Web.Models.Sistema.DatasComemorativas;
using SalaoDoPantcho.Web.Models.Sistema.Produtos;
using SalaoDoPantcho.Web.Models.Sistema.Promocoes;
using SalaoDoPantcho.Web.Models.Sistema.Servicos;

namespace SalaoDoPantcho.Web.AutoMapper
{
    // Mapeamento Saída de Dados...
    public class EntityToModelMapper : Profile
    {
        //configurar os mapeamentos...
        protected override void Configure()
        {
            // Acessórios...
            Mapper.CreateMap<Acessorios, ViewModelAcessoriosInserir>();
            Mapper.CreateMap<Acessorios, ViewModelAcessoriosAtualizar>();
            Mapper.CreateMap<Acessorios, ViewModelAcessoriosExcluir>();
            Mapper.CreateMap<Acessorios, ViewModelAcessoriosPesquisarPorNome>();

            // Administrador...
            Mapper.CreateMap<Administradores, ViewModelAdministradorInserir>();
            Mapper.CreateMap<Administradores, ViewModelAdministradorAtualizar>();
            Mapper.CreateMap<Administradores, ViewModelAdministradorExcluir>();
            Mapper.CreateMap<Administradores, ViewModelAdministradorVincularClienteAProdutos>();
            Mapper.CreateMap<Administradores, ViewModelAdministradorVincularClienteAPromocaoDatasComemorativas>();
            Mapper.CreateMap<Administradores, ViewModelAdministradorVincularClienteAPromocao>();
            Mapper.CreateMap<Administradores, ViewModelAdministradorVincularClienteAServico>();

            // Cliente...
            Mapper.CreateMap<Clientes, ViewModelClientesInserir>();
            Mapper.CreateMap<Clientes, ViewModelClientesAtualizar>();
            Mapper.CreateMap<Clientes, ViewModelClientesExcluir>();
            Mapper.CreateMap<Clientes, ViewModelClientesPesquisarClientePorLoginSenha>();
            Mapper.CreateMap<Clientes, ViewModelClientesLoginSistema>();
            Mapper.CreateMap<Clientes, ViewModelClientesPesquisarClientePorLoginEmail>();
            Mapper.CreateMap<Clientes, ViewModelClientesPesquisarClientePorLoginSenha>();

            // Datas Comemorativas...
            Mapper.CreateMap<DatasComemorativas, ViewModelDatasComemorativasInserir>();
            Mapper.CreateMap<DatasComemorativas, ViewModelDatasComemorativasAtualizar>();
            Mapper.CreateMap<DatasComemorativas, ViewModelDatasComemorativasExcluir>();
            Mapper.CreateMap<DatasComemorativas, ViewModelDatasComemorativasPesquisarDatasComemorativasPorDescricao>();
            Mapper.CreateMap<DatasComemorativas, ViewModelDatasComemorativasPesquisarDatasComemorativasPorDescricaoEDataComemorativa>();

            // Produtos...
            Mapper.CreateMap<Produtos, ViewModelProdutosInserir>();
            Mapper.CreateMap<Produtos, ViewModelProdutosAtualizar>();
            Mapper.CreateMap<Produtos, ViewModelProdutosExcluir>();
            Mapper.CreateMap<Produtos, ViewModelProdutosPesquisarProdutoPorDataFabricante>();
            Mapper.CreateMap<Produtos, ViewModelProdutosPesquisarProdutoPorDataValidade>();
            Mapper.CreateMap<Produtos, ViewModelProdutosPesquisarProdutoPorFabricante>();
            Mapper.CreateMap<Produtos, ViewModelProdutosPesquisarProdutoPorNome>();

            // Promoções...
            Mapper.CreateMap<Promocoes, ViewModelPromocaoInserir>();
            Mapper.CreateMap<Promocoes, ViewModelPromocaoAtualizar>();
            Mapper.CreateMap<Promocoes, ViewModelPromocaoExcluir>();
            Mapper.CreateMap<Promocoes, ViewModelPromocaoPesquisarPromocaoPorNome>();
            Mapper.CreateMap<Promocoes, ViewModelPromocaoPesquisarPromocoesPorDataFim>();
            Mapper.CreateMap<Promocoes, ViewModelPromocaoPesquisarPromocoesPorDataInicio>();
            Mapper.CreateMap<Promocoes, ViewModelPromocaoPesquisarPromocoesPorDataInicioFim>();

            // Serviços...
            Mapper.CreateMap<Servicos, ViewModelServicosInserir>();
            Mapper.CreateMap<Servicos, ViewModelServicosAtualizar>();
            Mapper.CreateMap<Servicos, ViewModelServicosExcluir>();
            Mapper.CreateMap<Servicos, ViewModelServicosPesquisarServicosPorGenero>();
            Mapper.CreateMap<Servicos, ViewModelServicosPesquisarServicosPorNome>();
            Mapper.CreateMap<Servicos, ViewModelServicosPesquisarServicosPorPreco>();
        }
    }
}