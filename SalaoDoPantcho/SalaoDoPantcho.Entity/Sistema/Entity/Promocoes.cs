using System;
using System.Collections.Generic;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class Promocoes
    {
        #region Atributos

        public virtual int IdPromocao { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual DateTime DataInicio { get; set; }
        public virtual DateTime DataFim { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<ClientesPromocoes> Clientes { get; set; }

        #endregion
    }
}