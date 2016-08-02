using System;
using System.Collections.Generic;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class Produtos
    {
        #region Atributos

        public virtual int IdProduto { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Fabricante { get; set; }
        public virtual DateTime DataFabricacao { get; set; }
        public virtual DateTime DataValidade { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<ClientesProdutos> Clientes { get; set; }

        #endregion
    }
}