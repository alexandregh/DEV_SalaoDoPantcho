using System;
using System.Collections.Generic;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class Clientes : Pessoas
    {
        #region Construtor

        public Clientes()
        {
            
        }

        #endregion

        #region Atributos

        public virtual int IdCliente { get; set; }
        public virtual string Apelido { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        // FK...
        public virtual int IdEnderecoCli { get; set; }

        #endregion

        #region Associações

        public virtual EnderecosCliente EnderecosCliente { get; set; }
        public virtual ICollection<TelefonesCliente> TelefonesCliente { get; set; }
        public virtual ICollection<ClientesDatasComemorativas> DatasComemorativas { get; set; }
        public virtual ICollection<ClientesServicos> Servicos { get; set; }
        public virtual ICollection<ClientesPromocoes> Promocoes { get; set; }
        public virtual ICollection<ClientesProdutos> Produtos { get; set; }

        #endregion
    }
}