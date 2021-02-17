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

	public class Message
	{
		public string message { get; set; }
		public string dateCreated { get; set; }
		public string email { get; set; }
		public bool anonymous { get; set; }

		public Message(string msg, string dateMade, string emailAddr, bool anonymousUser)
		{
			message = msg;
			dateCreated = dateMade;
			email = emailAddr;
			anonymous = anonymousUser;
		}

		public override string ToString() {
			return message;
		}

		public string MessageInfo()
		{
			return $"email: {email} created on {dateCreated}";
		}
	}

	
}
