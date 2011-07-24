using System;
using System.IO;
using System.Reflection;
using System.Configuration;

using IBatisNet.DataAccess;
using IBatisNet.Common.Utilities;

using IBatisNet.Test.NUnit;

using NUnit.Framework;

namespace IBatisNet.Test.NUnit.DaoTests.Ado.MSSQL
{
	/// <summary>
	/// Summary description for AdoDaoTest.
	/// </summary>
	[Category("MSSQL")]
	public class AdoDaoTest : BaseDaoTest
	{
		/// <summary>
		/// Initialisation
		/// </summary>
		[SetUp] 
		public void SetUp() 
		{
			DaoManager.Configure( "dao_MSSQL_"
				 + ConfigurationSettings.AppSettings["providerType"] + ".config" );
			daoManager = DaoManager.GetInstance();

			InitScript( daoManager.LocalDataSource, ScriptDirectory + "account-init.sql" );
		}

	}
}