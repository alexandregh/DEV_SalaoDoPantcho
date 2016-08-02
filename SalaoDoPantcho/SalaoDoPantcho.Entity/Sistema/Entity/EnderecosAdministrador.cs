using System.Collections.Generic;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class EnderecosAdministrador : Enderecos
    {
        #region Construtor

        public EnderecosAdministrador()
        {
            
        }

        #endregion

        #region Atributos

        public virtual int IdEnderecoAdm { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<Administradores> Administradores { get; set; }

        #endregion
    }
}