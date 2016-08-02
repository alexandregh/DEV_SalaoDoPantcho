using System;
using System.Collections.Generic;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class DatasComemorativas
    {
        #region Atributos

        public virtual int IdDataComemorativa { get; set; }
        public virtual string Descricao { get; set; }
        public virtual DateTime DataComemorativa { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<ClientesDatasComemorativas> Clientes { get; set; }

        #endregion
    }
}