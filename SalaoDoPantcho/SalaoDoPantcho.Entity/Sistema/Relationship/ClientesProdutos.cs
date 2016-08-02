using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Entity.Sistema.Relationship
{
    public class ClientesProdutos
    {
        #region Atributos/Associações

        public virtual int IdCliente { get; set; }
        public virtual int IdProdutos { get; set; }

        //__________________________________________

        public virtual Clientes Cliente { get; set; }
        public virtual Produtos Produto { get; set; }

        #endregion
    }
}