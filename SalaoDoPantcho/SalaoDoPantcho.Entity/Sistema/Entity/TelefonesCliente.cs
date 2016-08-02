namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class TelefonesCliente : Telefones
    {
        #region Atributos

        public virtual int IdTelefone { get; set; }

        // FK...
        public virtual int IdCliente { get; set; }

        #endregion

        #region Associações

        public virtual Clientes Cliente { get; set; }

        #endregion
    }
}