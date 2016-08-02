using System;
using System.Collections.Generic;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class Administradores : Pessoas
    {
        #region Construtor

        public Administradores()
        {
            //this.TelefonesAdministrador = new List<TelefonesAdministrador>();
        }

        #endregion

        #region Atributos

        public virtual int IdAdministrador { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        // FK...
        public virtual int IdEnderecoAdm { get; set; }

        #endregion

        #region Associações

        public virtual EnderecosAdministrador EnderecosAdministrador { get; set; }
        public virtual ICollection<TelefonesAdministrador> TelefonesAdministrador { get; set; }

        #endregion
    }
}