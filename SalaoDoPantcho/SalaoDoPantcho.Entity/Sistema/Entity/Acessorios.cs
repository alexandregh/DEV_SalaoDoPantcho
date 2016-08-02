using System;
using System.Collections.Generic;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class Acessorios
    {
        #region Atributos

        public virtual int IdAcessorio { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<ServicosAcessorios> Servicos { get; set; }

        #endregion
    }
}