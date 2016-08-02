using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Entity.Sistema.Relationship
{
    public class ClientesPromocoes
    {
        #region Atributos/Associações

        public virtual int IdCliente { get; set; }
        public virtual int IdPromocao { get; set; }

        //_____________________________________________

        public virtual Clientes Cliente { get; set; }
        public virtual Promocoes Promocao { get; set; }

        #endregion
    }
}