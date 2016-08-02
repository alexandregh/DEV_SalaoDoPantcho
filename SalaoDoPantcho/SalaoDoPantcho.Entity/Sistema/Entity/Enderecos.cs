using System;
using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public abstract class Enderecos
    {
        #region Atributos

        public virtual string Descricao { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string CEP { get; set; }
        public virtual TipoEnderecos TipoEndereco { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        #endregion
    }
}