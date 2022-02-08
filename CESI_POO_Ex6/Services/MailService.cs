using CESI_POO_Ex6.Model.Core;
using System;
using System.Collections.Generic;

namespace CESI_POO_Ex6.Services
{
    public class MailService
    {
        private void initiateMailSending(string to, string subject)
        {
            Console.WriteLine("Sending email to " + to);
            Console.WriteLine("With Subject  " + subject);
        }

        private void endMailSending()
        {
            Console.WriteLine();
            Console.WriteLine("Email Sended successfully");
        }

        public void Send(string to, string subject, IEncoded sendable)
        {
            initiateMailSending(to, subject);

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>(sendable.GetValues());

            foreach(string key in keyValuePairs.Keys)
            {
                Console.WriteLine("\n\t" + key + " : " + keyValuePairs.GetValueOrDefault(key));
            }

            endMailSending();
        }


        public void Send(string to, string subject, string body)
        {
            initiateMailSending(to, subject);

            Console.WriteLine("Body : \n" + body);

            endMailSending();
        }

        public void Send(string to, string subject)
        {
            initiateMailSending(to, subject);

            endMailSending();
        }
    }
}