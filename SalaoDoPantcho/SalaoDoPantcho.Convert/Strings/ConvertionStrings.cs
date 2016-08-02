using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.Convert.Strings
{
    public class ConvertionStrings
    {
        #region Implementação Métodos Conversão de Strings

        public static Clientes ConverterStringsClienteToLower(Clientes cliente)
        {
            cliente.Nome = cliente.Nome.Trim().ToLower();
            cliente.Email = cliente.Email.Trim().ToLower();
            cliente.Login = cliente.Login.Trim().ToLower();
            cliente.Apelido = cliente.Apelido.Trim().ToLower();
            cliente.EnderecosCliente.Descricao = cliente.EnderecosCliente.Descricao.Trim().ToLower();
            cliente.EnderecosCliente.Complemento = cliente.EnderecosCliente.Complemento.Trim().ToLower();
            cliente.EnderecosCliente.Bairro = cliente.EnderecosCliente.Bairro.Trim().ToLower();
            return cliente;
        }

        //__________

        public static Administradores ConverterStringsAdministradorToLower(Administradores administrador)
        {
            administrador.Nome = administrador.Nome.Trim().ToLower();
            administrador.Email = administrador.Email.Trim().ToLower();
            administrador.Login = administrador.Login.Trim().ToLower();
            administrador.EnderecosAdministrador.Descricao = administrador.EnderecosAdministrador.Descricao.Trim().ToLower();
            administrador.EnderecosAdministrador.Complemento = administrador.EnderecosAdministrador.Complemento.Trim().ToLower();
            administrador.EnderecosAdministrador.Bairro = administrador.EnderecosAdministrador.Bairro.Trim().ToLower();
            return administrador;
        }

        #endregion
    }
}