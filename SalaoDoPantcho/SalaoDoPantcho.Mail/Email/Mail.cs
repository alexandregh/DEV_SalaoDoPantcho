using System;
using System.Text;
using System.Net;
using System.Net.Mail;
using SalaoDoPantcho.Entity.Utilitarios.Contatos;

namespace SalaoDoPantcho.Mail.Email
{
    public class Mail
    {
        #region Propriedades

        private static readonly string conta = "salaodopantcho@gmail.com";
        private static readonly string senha = "salaodopantcho1980";
        private static readonly string smtp = "smtp.gmail.com";
        private static readonly int porta = 587;

        #endregion

        #region Métodos

        public static void SendMail(Contato entidade)
        {
            try
            {
                SmtpClient client = new SmtpClient(smtp, porta);
                client.Credentials = new NetworkCredential(conta, senha);
                client.Host = smtp;
                client.EnableSsl = true;

                MailMessage mail = new MailMessage(entidade.Email, conta);
                mail.Sender = new MailAddress(entidade.Email, entidade.Nome); // Remetente...
                mail.From = new MailAddress(conta); // Destinatário...
                mail.Subject = entidade.Assunto; // Assunto...
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Body = entidade.Mensagem; // Corpo...
                mail.BodyEncoding = Encoding.UTF8;
                mail.Priority = MailPriority.Normal;
                try
                {
                    client.Send(mail);
                }
                catch (ArgumentNullException ex)
                {
                    throw new Exception("Ocorreu o seguinte erro ao enviar a mensagem: " + ex.Message);
                }
                catch (ArgumentException ex)
                {
                    throw new Exception("Ocorreu o seguinte erro ao enviar a mensagem: " + ex.Message);
                }
                catch (FormatException ex)
                {
                    throw new Exception("Ocorreu o seguinte erro ao enviar a mensagem: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu o seguinte erro ao enviar a mensagem: " + ex.Message);
                }
                finally
                {
                    client.Dispose();
                    mail.Dispose();
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }

            #endregion
        }
    }
}