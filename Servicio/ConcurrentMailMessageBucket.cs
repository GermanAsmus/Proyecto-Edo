using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ConcurrentMailMessageBucket : IConcurrentMailMessageBucket
    {
        private IProducerConsumerCollection<MailMessage> iFullMessages;
        private IProducerConsumerCollection<MailMessage> iMessageHeader;

        public IEnumerable<MailMessage> FullMessages
        {
            get
            {
                return this.iFullMessages; 
            }
        }

        public IEnumerable<MailMessage> MessageHeader
        {
            get
            {
                return this.iMessageHeader;
            }
        }

        public ConcurrentMailMessageBucket()
        {
            this.iFullMessages = new ConcurrentBag<MailMessage>();
            this.iMessageHeader = new ConcurrentBag<MailMessage>();
        }

        public bool AddFullMessage(MailMessage pFullMessage)
        {
            if (pFullMessage != null)
               return this.iFullMessages.TryAdd(pFullMessage);
            throw new ArgumentNullException(nameof(pFullMessage));
        }

        public bool AddHeaderMessage(MailMessage pHeaderMessage)
        {
            if (pHeaderMessage != null)
                return this.iFullMessages.TryAdd(pHeaderMessage);
            throw new ArgumentNullException(nameof(pHeaderMessage));
        }


    }
}
