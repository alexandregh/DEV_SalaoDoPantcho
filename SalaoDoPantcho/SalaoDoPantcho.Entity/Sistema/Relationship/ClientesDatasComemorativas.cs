using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Entity.Sistema.Relationship
{
    public class ClientesDatasComemorativas
    {
        #region Atributos/Associações

        public virtual int IdCliente { get; set; }
        public virtual int IdDataComemorativa { get; set; }

        //_________________________________________________

        public virtual Clientes Cliente { get; set; }
        public virtual DatasComemorativas DatasComemorativas { get; set; }

        #endregion
    }
}