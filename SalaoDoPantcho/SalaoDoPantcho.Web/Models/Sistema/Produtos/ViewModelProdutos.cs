using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalaoDoPantcho.Web.Models.Sistema.Produtos
{
    public class ViewModelProdutosInserir
    {
        [Required(ErrorMessage = "Campo Nome do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Produto com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Produto com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [Required(ErrorMessage = "Campo Descrição do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Descrição do Produto com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Descrição do Produto com no máximo 50 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [Required(ErrorMessage = "Campo Fabricante do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Fabricante do Produto com no mínimo 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Campo Fabricante do Produto com no máximo 30 caracteres.")]
        [Display(Name = "Fabricante: ")]
        public string Fabricante { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Fabricação do produto no formato inválido.")]
        [Display(Name = "Data de Fabricação: ")]
        public DateTime DataFabricacao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Validade do produto no formato inválido.")]
        [Display(Name = "Data de Validade: ")]
        public DateTime DataValidade { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Cadastro do produto inválida.")]
        public DateTime DataCadastro { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do produto inválida.")]
        public DateTime DataAtualizacao { get; set; }
    }

    public class ViewModelProdutosAtualizar
    {
        [Required(ErrorMessage = "Campo Nome do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Produto com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Produto com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [Required(ErrorMessage = "Campo Descrição do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Descrição do Produto com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Descrição do Produto com no máximo 50 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [Required(ErrorMessage = "Campo Fabricante do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Fabricante do Produto com no mínimo 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Campo Fabricante do Produto com no máximo 30 caracteres.")]
        [Display(Name = "Fabricante: ")]
        public string Fabricante { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Fabricação do produto no formato inválido.")]
        [Display(Name = "Data de Fabricação: ")]
        public DateTime DataFabricacao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Validade do produto no formato inválido.")]
        [Display(Name = "Data de Validade: ")]
        public DateTime DataValidade { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do produto inválida.")]
        public DateTime DataAtualizacao { get; set; }
    }

    public class ViewModelProdutosExcluir
    {

    }

    public class ViewModelProdutosPesquisarProdutoPorDataFabricante
    {
        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Fabricação do produto no formato inválido.")]
        [Display(Name = "Data de Fabricação: ")]
        public DateTime DataFabricacao { get; set; }
    }

    public class ViewModelProdutosPesquisarProdutoPorDataValidade
    {
        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Validade do produto no formato inválido.")]
        [Display(Name = "Data de Validade: ")]
        public DateTime DataValidade { get; set; }
    }

    public class ViewModelProdutosPesquisarProdutoPorFabricante
    {
        [Required(ErrorMessage = "Campo Fabricante do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Fabricante do Produto com no mínimo 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Campo Fabricante do Produto com no máximo 30 caracteres.")]
        [Display(Name = "Fabricante: ")]
        public string Fabricante { get; set; }
    }

    public class ViewModelProdutosPesquisarProdutoPorNome
    {
        [Required(ErrorMessage = "Campo Nome do Produto é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Produto com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Produto com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }
    }
}