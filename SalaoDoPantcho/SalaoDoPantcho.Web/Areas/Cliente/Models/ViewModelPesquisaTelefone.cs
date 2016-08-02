using SalaoDoPantcho.Entity.Sistema.Enum;
using System.ComponentModel.DataAnnotations;

namespace SalaoDoPantcho.Web.Areas.Cliente.Models
{
    public class ViewModelPesquisaTelefone
    {
        [Display(Name = "DDD: ")]
        public byte DDD { get; set; }

        //________

        [Display(Name = "Número: ")]
        public int NumeroTel { get; set; }

        //________

        [Display(Name = "Tipo do Telefone: ")]
        public TipoTelefones TipoTelefone { get; set; }
    }
}