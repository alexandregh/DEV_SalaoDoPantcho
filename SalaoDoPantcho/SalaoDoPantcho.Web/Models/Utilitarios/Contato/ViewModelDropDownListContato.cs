using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaoDoPantcho.Web.Models.Utilitarios.Contato
{
    public class ViewModelDropDownListContato
    {
        public string AssuntoId { get; set; }
        public string Assunto { get; set; }

        public List<ViewModelDropDownListContato> listarItensContato()
        {
            return new List<ViewModelDropDownListContato>
            {
                new ViewModelDropDownListContato { AssuntoId = "", Assunto = "Informe um assunto..." },
                new ViewModelDropDownListContato { AssuntoId = "Duvidas", Assunto = "Dúvudas" },
                new ViewModelDropDownListContato { AssuntoId = "Elogios", Assunto = "Elogios" },
                new ViewModelDropDownListContato { AssuntoId = "Sugestões", Assunto = "Sugestões" },
                new ViewModelDropDownListContato { AssuntoId = "Outros", Assunto = "Outros" },
            };
        }
    }
}