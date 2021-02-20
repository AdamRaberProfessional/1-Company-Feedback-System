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

	class CompanyMessage
	{
		public string message {get; set;}
		public string dateCreated {get; set; }
		public string email { get; set; }

		public CompanyMessage(string msg, string date, string emailAddr)
		{
			message = msg;
			dateCreated = date;
			email = emailAddr;
		}
    }

	public class FeedbackMessage 
	{
		public string message { get; set; }
		public string dateCreated { get; set; }
		public Boolean anonymous { get; set; }
		public string email { get; set; }

		public FeedbackMessage(string msg, string dateMade, string emailAddr, bool isAnonymous)
        {
			message = msg;
			dateCreated = dateMade;
			email = emailAddr;
			anonymous = isAnonymous;
        }

	}
}
