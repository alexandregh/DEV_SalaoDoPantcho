using System;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public abstract class Telefones
    {
        #region Atributos

        public virtual byte DDD { get; set; }
        public virtual int Numero { get; set; }
        public virtual TipoTelefones TipoTelefone { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        #endregion
    }
}