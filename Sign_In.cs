using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorization
{
	class Sign_In
	{
		private string UserName;
		private string Email;
		private string Password;


		public Sign_In(string username,string email,string password)
		{
			UserName = username;
			Email = email;
			Password = password;
		}

		public void lll()
		{
			File.WriteAllText(@"C:\Users\dunduk\Desktop\lol.txt",$"{UserName} {Email} {Password}");
		}
	}
}
