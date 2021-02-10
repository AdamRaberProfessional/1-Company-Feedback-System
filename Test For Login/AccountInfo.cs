using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_For_Login
{
	class AccountInfo
	{
		private static string account = null;
		private static string email = null;
		public static string accountType()
		{
			return account;
		}
		public static void accountType(string acc)
		{
			account = acc;
		}
		public static string emailAddress()
		{
			return email;
		}
		public static void emailAddress(string e)
		{
			email = e;
		}
	}
}
