using System;
using System.IO;
using Sax.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDroid))]
namespace Sax.Droid
{
    public class SQLiteDroid : ISQLite
    {
        public SQLiteDroid()
        {
        }

		#region ISQLite implementation
		public SQLite.Net.SQLiteConnection GetConnection()
		{
			var file = "Person.db3";
			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentPath, file);

			var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			var connection = new SQLite.Net.SQLiteConnection(platform, path);

			return connection;
		}
		#endregion

	}
}
