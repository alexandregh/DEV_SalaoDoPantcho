using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Entity.Sistema.Relationship
{
    public class ClientesServicos
    {
        #region Atributos/Associações

        public virtual int IdCliente { get; set; }
        public virtual int IdServico { get; set; }

        //_________________________________________

        public virtual Clientes Cliente { get; set; }
        public virtual Servicos Servico { get; set; }

        #endregion
    }
}