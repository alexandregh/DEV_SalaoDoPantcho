namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public class TelefonesAdministrador : Telefones
    {
        #region Atributos

        public virtual int IdTelefone { get; set; }

        // FK...
        public virtual int IdAdministrador { get; set; }

        #endregion

        #region Associações

        public virtual Administradores Administrador { get; set; }

        #endregion
    }
}