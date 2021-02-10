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
}
