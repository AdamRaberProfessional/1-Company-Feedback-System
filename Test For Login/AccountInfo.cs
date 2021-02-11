using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_For_Login
{
	class AccountInfo
	{
		public string emailAddress { get; set; }
		public string accountType { get; set; }
		public AccountInfo(string email, string acctType)
        {
			emailAddress = email;
			accountType = acctType;
        }
	}

	class Message 
	{
		public string message { get; set; }
		public string dateCreated { get; set; }
		public Boolean anonymous { get; set; }
		public string email { get; set; }

		public Message(string msg, string dateMade, string emailAddr = null )
        {
			message = msg;
			dateCreated = dateMade;
			if(emailAddr != null)
            {
				anonymous = false;
				email = emailAddr;
			}
			else if (emailAddr == null)
            {
				anonymous = true;
				email = "N/A";
            }
			
        }

	}
}
