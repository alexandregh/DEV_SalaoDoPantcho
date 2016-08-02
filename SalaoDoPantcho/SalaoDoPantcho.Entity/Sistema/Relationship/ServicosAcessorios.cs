using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Entity.Sistema.Relationship
{
    public class ServicosAcessorios
    {
        #region Atributos/Associações

        public virtual int IdServico { get; set; }
        public virtual int IdAcessorio { get; set; }

       // ___________________________________________

        public virtual Servicos Servico { get; set; }
        public virtual Acessorios Acessorio { get; set; }

        #endregion
    }
}