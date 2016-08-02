using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Web.Models.Sistema.Servicos
{
    public class ViewModelServicosInserir
    {
        [Required(ErrorMessage = "Campo Nome do serviço é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do serviço com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do serviço com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [MinLength(3, ErrorMessage = "Campo Descrição do serviço com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Descrição do serviço com no máximo 100 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [Required(ErrorMessage = "Campo Preço do serviço é obrigatório.")]
        [Range(0, Double.MaxValue, ErrorMessage = "Valor do Preço do serviço não está fora do intervalo permitido.")]
        [Display(Name = "Preço: ")]
        public decimal Preco { get; set; }

        //________

        [Display(Name = "Gênero: ")]
        public GeneroServico Genero { get; set; }

        //________


        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Cadastro do serviço inválida.")]
        public DateTime DataCadastro { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do serviço inválida.")]
        public DateTime DataAtualizacao { get; set; }
    }

    public class ViewModelServicosAtualizar
    {
        [Required(ErrorMessage = "Campo Nome do serviço é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do serviço com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do serviço com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [MinLength(3, ErrorMessage = "Campo Descrição do serviço com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Descrição do serviço com no máximo 100 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [Required(ErrorMessage = "Campo Preço do serviço é obrigatório.")]
        [Range(0, Double.MaxValue, ErrorMessage = "Valor do Preço do serviço não está fora do intervalo permitido.")]
        [Display(Name = "Preço: ")]
        public decimal Preco { get; set; }

        //________

        [Required(ErrorMessage = "Campo Preço do serviço é obrigatório.")]
        [Display(Name = "Gênero: ")]
        public GeneroServico Genero { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do serviço inválida.")]
        public DateTime DataAtualizacao { get; set; }
    }

    public class ViewModelServicosExcluir
    {

    }

    public class ViewModelServicosPesquisarServicosPorGenero
    {
        [Required(ErrorMessage = "Campo Preço do serviço é obrigatório.")]
        [Display(Name = "Gênero: ")]
        public GeneroServico Genero { get; set; }
    }

    public class ViewModelServicosPesquisarServicosPorNome
    {
        [Required(ErrorMessage = "Campo Nome do serviço é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do serviço com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do serviço com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }
    }

    public class ViewModelServicosPesquisarServicosPorPreco
    {
        [Required(ErrorMessage = "Campo Preço do serviço é obrigatório.")]
        [Range(0, Double.MaxValue, ErrorMessage = "Valor do Preço do serviço não está fora do intervalo permitido.")]
        [Display(Name = "Preço: ")]
        public decimal Preco { get; set; }
    }
}