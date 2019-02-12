using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.IO;


namespace SabinoFarma.Models
{
    public class DadosEmail
    {
        public async static Task  Envio(Email model)
        {        

            var body = "<p>Contato Feito Por: {0} ({1})</p><p><b>--------------------MENSAGEM:-----------------</b>:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("sabinofarma@hotmail.com"));  // replace with valid value 
            message.From = new MailAddress("sabinofarma@hotmail.com");  // replace with valid value
            message.Subject = "E-mail recebido pelo Site";
            message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message, model.Telefone);
            message.IsBodyHtml = true;

            //foreach (var item in Email)
            //{

            //}
            if (model.Upload != null && model.Upload.ContentLength > 0)
            {
                message.Attachments.Add(new Attachment(model.Upload.InputStream, Path.GetFileName(model.Upload.FileName)));
            } 

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "sabinofarma@hotmail.com",  // replace with valid value
                    Password = "drogaria2017"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
            }
        }
    }
}
