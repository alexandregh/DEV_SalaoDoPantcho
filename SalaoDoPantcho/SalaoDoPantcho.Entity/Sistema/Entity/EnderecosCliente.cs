using System.Collections.Generic;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class EnderecosCliente : Enderecos
    {
        #region Construtor

        public EnderecosCliente()
        {

        }

        #endregion

        #region Atributos

        public virtual int IdEnderecoCli { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<Clientes> Clientes { get; set; }

        #endregion
    }
}