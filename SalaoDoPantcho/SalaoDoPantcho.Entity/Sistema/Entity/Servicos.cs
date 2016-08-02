using System;
using System.Collections.Generic;
using SalaoDoPantcho.Entity.Sistema.Enum;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class Servicos
    {
        #region Atributos

        public virtual int IdServico { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual GeneroServico GeneroServico { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        #endregion

        #region Assiciações

        public virtual ICollection<ServicosAcessorios> Acessorios { get; set; }
        public virtual ICollection<ClientesServicos> Clientes { get; set; }

        #endregion
    }
}