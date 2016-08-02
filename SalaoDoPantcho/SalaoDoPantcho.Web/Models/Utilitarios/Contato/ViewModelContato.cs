using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SalaoDoPantcho.Web.Models.Utilitarios.Contato
{
    public class ViewModelContato
    {
        #region Propriedades

        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //___________

        [Required(ErrorMessage = "Campo Email é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Email com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Email com no máximo 50 caracteres.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Campo Email está incorreto.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        //___________

        [Required(ErrorMessage = "Campo Assunto do Email é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Assunto do Email com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Assunto do Email com no máximo 50 caracteres.")]
        [Display(Name = "Assunto: ")]
        public string Assunto { get; set; }

        //___________

        [Required(ErrorMessage = "Campo Mensagem do Email é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Mensagem do Email com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Mensagem do Email com no máximo 500 caracteres.")]
        [Display(Name = "Mensagem: ")]
        public string Mensagem { get; set; }

        #endregion
    }
}