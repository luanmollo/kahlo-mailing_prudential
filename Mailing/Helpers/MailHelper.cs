namespace Mailing.Helpers
{
    public class MailHelper
    {
        public void EnviarEmail(string emailTo, string subject, string template, string emailFrom)
        {
            var serviceBaseAddress = "internalrelay-mail.prudential.com";

            var apiEmail = "WSMail/api/Emails/SendEmail";



            System.Net.WebClient webClient = new System.Net.WebClient();



            webClient.BaseAddress = serviceBaseAddress;



            EmailPrudential model = new EmailPrudential()

            {

                pto = emailTo,

                psubject = subject,

                pcc = string.Empty,

                pmsg = template,

                pfrom = emailFrom,

                papp = "Prudential Seguros",

                phtml = true,

                pisdebug = false

            };



            var reqparm = new System.Collections.Specialized.NameValueCollection();



            reqparm.Add("pto", model.pto); //mail del destinatario

            reqparm.Add("pcc", model.pcc); //mail de con copia

            reqparm.Add("pfrom", model.pfrom); //mail de salida

            reqparm.Add("psubject", model.psubject); //asunto

            reqparm.Add("pmsg", model.pmsg); //cuerpo del mail

            reqparm.Add("pHtml", model.phtml.ToString());  //si tiene o no contenido html

            reqparm.Add("papp", model.papp); //aplicacion

            reqparm.Add("pisdebug", model.pisdebug.ToString()); //si es debug = true, sale mail al configurado en la api.



            webClient.UploadValues(new Uri(webClient.BaseAddress + apiEmail), "POST", reqparm);
        }
    }
}
