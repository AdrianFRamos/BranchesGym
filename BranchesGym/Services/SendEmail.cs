using System;
using System.Net;
using System.Net.Mail;

namespace BranchesGym.Services
{
    public class EmailService
    {
        public static void EnviarEmail(string emailDestino)
        {
            try
            {
                // Configurações do remetente
                var fromAddress = new MailAddress("seuemail@exemplo.com", "Branches Gym");
                var toAddress = new MailAddress(emailDestino);
                const string fromPassword = "senha-do-email";
                const string subject = "Redefinição de Senha";
                const string body = "Clique no link abaixo para redefinir sua senha:\n\nhttps://seu-site.com/redefinir-senha";

                // Configuração do servidor SMTP
                var smtp = new SmtpClient
                {
                    Host = "smtp.exemplo.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                // Mensagem de e-mail
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message); // Envia o e-mail
                    Console.WriteLine("E-mail enviado com sucesso para: " + emailDestino);
                }
            }
            catch (Exception ex)
            {
                // Tratamento de erros
                Console.WriteLine("Erro ao enviar e-mail: " + ex.Message);
            }
        }

    }
}
