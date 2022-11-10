using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Notenverwaltung.DataAccess
{
	internal class Datenbank
	{
		string _connectionString;

		public Datenbank(string connectionString)
		{
			_connectionString = connectionString;
		}
	}
}
