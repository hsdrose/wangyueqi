using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SendMailAndReceiveMail
{
    class MailInfo
    {
      public string FromMail
        {
            get;
            set;
        }

      public string MailSubject
      {
          get;
          set;
      }

      public string MailMessage
      {
          get;
          set;
      }

      public List<string> atts
      {
          get;
          set;
      }
   }
}
