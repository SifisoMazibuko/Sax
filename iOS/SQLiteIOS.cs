using System;
using System.IO;
using Sax.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteIOS))]
namespace Sax.iOS
{
    public class SQLiteIOS : ISQLite
    {
        public SQLiteIOS()
        {
        }
		#region SQLiteIOS Implementation

		public SQLite.Net.SQLiteConnection GetConnection()
		{
			var file = "Person.db3";
			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentPath, "..", "library");

			var path = Path.Combine(libraryPath, file);
			var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
			var connection = new SQLite.Net.SQLiteConnection(platform, path);

			return connection;
		}
		#endregion
	}

}

