using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.SOLID
{
    public class SMS : IMessage
    {
        public string Number { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            SendSms();
        }

        public void SendSms()
        {
            Console.WriteLine("Sending SMS..");
        }
    }

    public class Email : IMessage
    {
        public string Number { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendEmail()
        {
            Console.WriteLine("Sending email..");
        }
        public void SendMessage()
        {
            SendEmail();
        }

    }

    public class MMS : IMessage
    {

        public string Number { get; set; }
        public byte[] Content { get; set; }

        public void SendMms()
        {
            Console.WriteLine("Sending MMS..");
        }
        public void SendMessage()
        {
            SendMms();
        }
    }

    public interface IMessage {
        void SendMessage();
        }


    public class Messanger
    {
        public IEnumerable<IMessage> Services { get; set; }

        public void SendMessage()
        {
            if(Services != null)
                foreach (var item in Services)
                {
                    item.SendMessage();
                }
        }
    }
}
