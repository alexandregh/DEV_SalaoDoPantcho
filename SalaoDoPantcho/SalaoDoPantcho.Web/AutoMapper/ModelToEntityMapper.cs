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
    // Mapeamento Entrada de Dados...
    public class ModelToEntityMapper : Profile
    {
        //configurar os mapeamentos...
        protected override void Configure()
        {
            // Acessórios...
            Mapper.CreateMap<ViewModelAcessoriosInserir, Acessorios>();
            Mapper.CreateMap<ViewModelAcessoriosAtualizar, Acessorios>();
            Mapper.CreateMap<ViewModelAcessoriosExcluir, Acessorios>();
            Mapper.CreateMap<ViewModelAcessoriosPesquisarPorNome, Acessorios>();

            // Administrador...
            Mapper.CreateMap<ViewModelAdministradorInserir, Administradores>();
            Mapper.CreateMap<ViewModelAdministradorAtualizar, Administradores>();
            Mapper.CreateMap<ViewModelAdministradorExcluir, Administradores>();
            Mapper.CreateMap<ViewModelAdministradorVincularClienteAProdutos, Administradores>();
            Mapper.CreateMap<ViewModelAdministradorVincularClienteAPromocaoDatasComemorativas, Administradores>();
            Mapper.CreateMap<ViewModelAdministradorVincularClienteAPromocao, Administradores>();
            Mapper.CreateMap<ViewModelAdministradorVincularClienteAServico, Administradores>();

            // Cliente...
            Mapper.CreateMap<ViewModelClientesInserir, Clientes>();
            Mapper.CreateMap<ViewModelClientesAtualizar, Clientes>();
            Mapper.CreateMap<ViewModelClientesExcluir, Clientes>();
            Mapper.CreateMap<ViewModelClientesPesquisarClientePorLoginSenha, Clientes>();
            Mapper.CreateMap<ViewModelClientesLoginSistema, Clientes>();
            Mapper.CreateMap<ViewModelClientesPesquisarClientePorLoginEmail, Clientes>();
            Mapper.CreateMap<ViewModelClientesPesquisarClientePorLoginSenha, Clientes>();

            // Datas Comemorativas...
            Mapper.CreateMap<ViewModelDatasComemorativasInserir, DatasComemorativas>();
            Mapper.CreateMap<ViewModelDatasComemorativasAtualizar, DatasComemorativas>();
            Mapper.CreateMap<ViewModelDatasComemorativasExcluir, DatasComemorativas>();
            Mapper.CreateMap<ViewModelDatasComemorativasPesquisarDatasComemorativasPorDescricao, DatasComemorativas>();
            Mapper.CreateMap<ViewModelDatasComemorativasPesquisarDatasComemorativasPorDescricaoEDataComemorativa, DatasComemorativas>();

            // Produtos...
            Mapper.CreateMap<ViewModelProdutosInserir, Produtos>();
            Mapper.CreateMap<ViewModelProdutosAtualizar, Produtos>();
            Mapper.CreateMap<ViewModelProdutosExcluir, Produtos>();
            Mapper.CreateMap<ViewModelProdutosPesquisarProdutoPorDataFabricante, Produtos>();
            Mapper.CreateMap<ViewModelProdutosPesquisarProdutoPorDataValidade, Produtos>();
            Mapper.CreateMap<ViewModelProdutosPesquisarProdutoPorFabricante, Produtos>();
            Mapper.CreateMap<ViewModelProdutosPesquisarProdutoPorNome, Produtos>();

            // Promoções...
            Mapper.CreateMap<ViewModelPromocaoInserir, Promocoes>();
            Mapper.CreateMap<ViewModelPromocaoAtualizar, Promocoes>();
            Mapper.CreateMap<ViewModelPromocaoExcluir, Promocoes>();
            Mapper.CreateMap<ViewModelPromocaoPesquisarPromocaoPorNome, Promocoes>();
            Mapper.CreateMap<ViewModelPromocaoPesquisarPromocoesPorDataFim, Promocoes>();
            Mapper.CreateMap<ViewModelPromocaoPesquisarPromocoesPorDataInicio, Promocoes>();
            Mapper.CreateMap<ViewModelPromocaoPesquisarPromocoesPorDataInicioFim, Promocoes>();

            // Serviços...
            Mapper.CreateMap<ViewModelServicosInserir, Servicos>();
            Mapper.CreateMap<ViewModelServicosAtualizar, Servicos>();
            Mapper.CreateMap<ViewModelServicosExcluir, Servicos>();
            Mapper.CreateMap<ViewModelServicosPesquisarServicosPorGenero, Servicos>();
            Mapper.CreateMap<ViewModelServicosPesquisarServicosPorNome, Servicos>();
            Mapper.CreateMap<ViewModelServicosPesquisarServicosPorPreco, Servicos>();
        }
    }
}