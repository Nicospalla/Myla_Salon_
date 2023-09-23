using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.Rest.Lookups.V2;
using Twilio.TwiML.Messaging;
using System.Diagnostics;

namespace Accesorios
{
    public class WhatsappServices
    {

        public void enviarWSAPP(DateTime dia,TimeSpan hora, string nombre, string tel, string esp)
        {
            var accountSid = "AC0203e032870f1d909e452226e7646f42";
            var authToken = "aef97f031b2f85477acb141050224448";
            TwilioClient.Init(accountSid, authToken);
            
            var messageOptions = new CreateMessageOptions(
              new PhoneNumber($"whatsapp:+34{tel}"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = @$"Hola {nombre}! Te enviamos un recordatorio de tu cita para el dia {dia} a las {hora} con {esp}. Te esperamos!!";


            var message = MessageResource.Create(messageOptions);
            //Console.WriteLine(message.Body);
        }
    }
}
