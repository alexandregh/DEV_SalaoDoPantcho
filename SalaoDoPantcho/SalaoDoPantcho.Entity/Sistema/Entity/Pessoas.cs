using SalaoDoPantcho.Entity.Sistema.Enum;

namespace SalaoDoPantcho.Entity.Sistema.Entity
{
    public abstract class Pessoas
    {
        #region Atributos

        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual GeneroSexo GeneroSexo { get; set; }
        public virtual StatusPessoa StatusPessoa { get; set; }
        public virtual Perfil Perfil { get; set; }

        #endregion
    }
}