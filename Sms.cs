using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class Sms : INotification
    {
        public string sender { get; set; }
        public string receiver { get; set; }
        public string text { get; set; }
        public void send(string rec)
        {
            Console.WriteLine($"SMS: “{text}” გაეგზავნა {sender}-დან {rec}-ს.");
        }
        public void receive()
        {
            Console.WriteLine($"SMS: “{text}” გაეგზავნა {sender}-დან {receiver}-ს.");

        }
        public Sms(string sender, string receiver, string text)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.text = text;
        }
    }
}
