using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SalaoDoPantcho.Web.Models.Sistema.Administrador
{
    public class ViewModelAdministradorInserir
    {
        [Required(ErrorMessage = "Campo Nome do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Administrador com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [Required(ErrorMessage = "Campo Email do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Email do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Email do Administrador com no máximo 50 caracteres.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Campo Email do Administrador está incorreto.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        //________

        [Required(ErrorMessage = "Campo Login do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Login do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Login do Administrador com no máximo 50 caracteres.")]
        [Display(Name = "Login: ")]
        public string Login { get; set; }

        //________

        [Required(ErrorMessage = "Campo Senha do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Senha do Administrador com no máximo 50 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Cadastro do administrador inválida.")]
        public DateTime DataCadastro { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do administrador inválida.")]
        public DateTime DataAlteracao { get; set; }
    }

    public class ViewModelAdministradorAtualizar
    {
        [Required(ErrorMessage = "Campo Nome do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Administrador com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [Required(ErrorMessage = "Campo Email do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Email do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Email do Administrador com no máximo 50 caracteres.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Campo Email do Administrador está incorreto.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        //________

        [Required(ErrorMessage = "Campo Login do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Login do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Login do Administrador com no máximo 50 caracteres.")]
        [Display(Name = "Login: ")]
        public string Login { get; set; }

        //________

        [Required(ErrorMessage = "Campo Senha do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Senha do Administrador com no máximo 50 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        //________

        [DataType(DataType.DateTime, ErrorMessage = "Campo Data de Atualização do administrador inválida.")]
        public DateTime DataAlteracao { get; set; }
    }

    public class ViewModelAdministradorExcluir
    {

    }

    public class ViewModelAdministradorVincularClienteAProdutos
    {

    }

    public class ViewModelAdministradorVincularClienteAPromocao
    {

    }

    public class ViewModelAdministradorVincularClienteAPromocaoDatasComemorativas
    {

    }

    public class ViewModelAdministradorVincularClienteAServico
    {

    }
}