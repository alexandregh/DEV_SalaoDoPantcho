using SalaoDoPantcho.Entity.Sistema.Enum;
using System.ComponentModel.DataAnnotations;

namespace SalaoDoPantcho.Web.Areas.Cliente.Models
{
    public class ViewModelClientesAtualizar
    {
        // Dados do Cliente...

        [Required(ErrorMessage = "Campo Nome do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Cliente com no máximo 50 caracteres.")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [MaxLength(30, ErrorMessage = "Campo Apelido do Cliente com no máximo 30 caracteres.")]
        [Display(Name = "Apelido: ")]
        public string Apelido { get; set; }

        //________

        [Required(ErrorMessage = "Campo Email do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Email do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Email do Cliente com no máximo 50 caracteres.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Campo Email do Cliente está incorreto.")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        //________

        [Required(ErrorMessage = "Campo Login do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Login do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Login do Cliente com no máximo 50 caracteres.")]
        [Display(Name = "Login: ")]
        public string Login { get; set; }

        //________

        [Required(ErrorMessage = "Campo Senha do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Senha do Cliente com no máximo 50 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        //________

        [Required(ErrorMessage = "Campo Sexo do Cliente é obrigatório.")]
        [Display(Name = "Sexo: ")]
        public GeneroSexo Genero { get; set; }

        // Dados do Endereço do Cliente...

        [Display(Name = "Tipo do Endereço: ")]
        public TipoEnderecos TipoEndereco { get; set; }

        //________

        [Required(ErrorMessage = "Campo Descrição do Endereço é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Descrição do Endereço com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Descrição do Endereço com no máximo 100 caracteres.")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        //________

        [MaxLength(6, ErrorMessage = "Campo Numero do Endereço com no máximo 6 caracteres.")]
        [Display(Name = "Número: ")]
        public string NumeroEnd { get; set; }

        //________

        [MaxLength(100, ErrorMessage = "Campo Complemento do Endereço com no máximo 100 caracteres.")]
        [Display(Name = "Complemento: ")]
        public string Complemento { get; set; }

        //________

        [Required(ErrorMessage = "Campo Bairro do Endereço é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Bairro do Endereço com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Bairro do Endereço com no máximo 50 caracteres.")]
        [Display(Name = "Bairro: ")]
        public string Bairro { get; set; }

        //________

        [Required(ErrorMessage = "Campo Cep do Endereço é obrigatório.")]
        [StringLength(10, ErrorMessage = "Campo Cep do Endereço deverá possuir 10 caracteres.")]
        [Display(Name = "Cep: ")]
        public string Cep { get; set; }

        // Dados do Telefone do Cliente...

        [Display(Name = "DDD: ")]
        public byte DDD { get; set; }

        //________

        [Required(ErrorMessage = "Campo Número do Telefone é obrigatório.")]
        [Display(Name = "Número: ")]
        public int NumeroTel { get; set; }

        //________

        [Display(Name = "Tipo do Telefone: ")]
        public TipoTelefones TipoTelefone { get; set; }
    }

    public class ViewModelClienteTrocarSenha
    {
        [Required(ErrorMessage = "Campo Login do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Login do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Login do Cliente com no máximo 50 caracteres.")]
        [Display(Name = "Login: ")]
        public string Login { get; set; }

        //________

        [Required(ErrorMessage = "Campo Senha Atual do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha Atual do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Senha Atual do Cliente com no máximo 50 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha Atual: ")]
        public string SenhaAtual { get; set; }

        //________

        [Required(ErrorMessage = "Campo Nova Senha do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nova Senha do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nova Senha do Cliente com no máximo 50 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha: ")]
        public string NovaSenha { get; set; }
    }

    public class ViewModelClienteAtivarDesativar
    {
        [Required(ErrorMessage = "Campo Login do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Login do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Login do Cliente com no máximo 50 caracteres.")]
        [Display(Name = "Login: ")]
        public string Login { get; set; }

        //________

        [Required(ErrorMessage = "Campo Senha do Cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha do Cliente com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Senha do Cliente com no máximo 50 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        //________

        [Required(ErrorMessage = "Campo Status do Cliente é obrigatório.")]
        [Display(Name = "Status do Cliente: ")]
        public StatusPessoa StatusCliente { get; set; }
    }

    public class ViewModelPesquisaCliente
    {
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //________

        [Display(Name = "Apelido: ")]
        public string Apelido { get; set; }

        //________

        [Display(Name = "Nome ou Apelido: ")]
        public string Nomeapelido { get; set; }

        //________

        [Display(Name = "Email: ")]
        public string Email { get; set; }

        //________

        [Display(Name = "Login: ")]
        public string Login { get; set; }

        //________

        [Display(Name = "Senha: ")]
        public string Senha { get; set; }

        //________

        [Display(Name = "Sexo: ")]
        public GeneroSexo Sexo { get; set; }

        //________

        [Display(Name = "Perfil: ")]
        public Perfil PerfilCliente { get; set; }

        //________

        [Display(Name = "Gênero: ")]
        public GeneroSexo GeneroCliente { get; set; }

        //________

        [Display(Name = "Status: ")]
        public StatusPessoa StatusPessoa { get; set; }
    }
}