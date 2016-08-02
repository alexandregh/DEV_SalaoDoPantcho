using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalaoDoPantcho.Web.Models.Sistema.Promocoes
{
    public class ViewModelPromocaoInserir
    {
        [Required(ErrorMessage = "Campo Nome da Promoção é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Promoção com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Promoção com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [MinLength(3, ErrorMessage = "Campo Descrição da Promoção com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Descrição da Promoção com no máximo 100 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Inicial da promoção no formato inválido.")]
        [Display(Name = "Data Inicial: ")]
        public DateTime DataFabricacao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Final da promoção no formato inválido.")]
        [Display(Name = "Data Final: ")]
        public DateTime DataValidade { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Cadastro da promoção inválida.")]
        public DateTime DataCadastro { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização da promoção inválida.")]
        public DateTime DataAtualizacao { get; set; }
    }

    public class ViewModelPromocaoAtualizar
    {
        [Required(ErrorMessage = "Campo Nome da Promoção é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Promoção com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Promoção com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [MinLength(3, ErrorMessage = "Campo Descrição da Promoção com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Descrição da Promoção com no máximo 100 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Inicial da promoção no formato inválido.")]
        [Display(Name = "Data Inicial: ")]
        public DateTime DataFabricacao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Final da promoção no formato inválido.")]
        [Display(Name = "Data Final: ")]
        public DateTime DataValidade { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização da promoção inválida.")]
        public DateTime DataAtualizacao { get; set; }
    }

    public class ViewModelPromocaoExcluir
    {

    }

    public class ViewModelPromocaoPesquisarPromocaoPorNome
    {
        [Required(ErrorMessage = "Campo Nome da Promoção é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Promoção com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Promoção com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }
    }

    public class ViewModelPromocaoPesquisarPromocoesPorDataFim
    {
        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Final da promoção no formato inválido.")]
        [Display(Name = "Data Final: ")]
        public DateTime DataValidade { get; set; }
    }

    public class ViewModelPromocaoPesquisarPromocoesPorDataInicio
    {
        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Inicial da promoção no formato inválido.")]
        [Display(Name = "Data Inicial: ")]
        public DateTime DataFabricacao { get; set; }
    }

    public class ViewModelPromocaoPesquisarPromocoesPorDataInicioFim
    {
        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Inicial da promoção no formato inválido.")]
        [Display(Name = "Data Inicial: ")]
        public DateTime DataFabricacao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data Final da promoção no formato inválido.")]
        [Display(Name = "Data Final: ")]
        public DateTime DataValidade { get; set; }
    }
}