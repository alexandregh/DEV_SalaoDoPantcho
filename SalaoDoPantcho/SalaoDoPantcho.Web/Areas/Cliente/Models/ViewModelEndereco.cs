using SalaoDoPantcho.Entity.Sistema.Enum;
using System.ComponentModel.DataAnnotations;

namespace SalaoDoPantcho.Web.Areas.Cliente.Models
{
    public class ViewModelPesquisaEndereco
    {
        [Display(Name = "Tipo do Endereço: ")]
        public TipoEnderecos TipoEndereco { get; set; }

        //________

        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [Display(Name = "Número: ")]
        public string NumeroEnd { get; set; }

        //________

        [Display(Name = "Complemento: ")]
        public string Complemento { get; set; }

        //________

        [Display(Name = "Bairro: ")]
        public string Bairro { get; set; }

        //________

        [Display(Name = "Cep: ")]
        public string Cep { get; set; }
    }
}