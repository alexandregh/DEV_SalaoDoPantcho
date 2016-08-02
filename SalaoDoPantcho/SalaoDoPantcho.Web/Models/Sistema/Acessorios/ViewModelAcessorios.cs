using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalaoDoPantcho.Web.Models.Sistema.Acessorios
{
    public class ViewModelAcessoriosInserir
    {
        [Required(ErrorMessage = "Campo Nome do Acessório é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Acessório com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Acessório com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [Required(ErrorMessage = "Campo Descrição do Acessório é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Descrição do Acessório com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Acessório com no máximo 500 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Cadastro do acessório inválida.")]
        public DateTime DataCadastro { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do acessório inválida.")]
        public DateTime DataAlteracao { get; set; }
    }

    public class ViewModelAcessoriosAtualizar
    {
        [Required(ErrorMessage = "Campo Nome do Acessório é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Acessório com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Acessório com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [Required(ErrorMessage = "Campo Descrição do Acessório é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Descrição do Acessório com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Acessório com no máximo 500 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do acessório inválida.")]
        public DateTime DataAlteracao { get; set; }
    }

    public class ViewModelAcessoriosExcluir
    {

    }

    public class ViewModelAcessoriosPesquisarPorNome
    {
        [Required(ErrorMessage = "Campo Nome do Acessório é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Acessório com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Acessório com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }
    }
}