using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;

namespace Sax.DbConnection
{
    public class createDatabase
    {
		private SQLiteConnection _con;
		public createDatabase()
		{
			_con = DependencyService.Get<ISQLite>().GetConnection();
			_con.CreateTable<Person>();
		}
		public IEnumerable<Person> GetPerson()
		{
			return (from p in _con.Table<Person>()
					select p).ToList();
		}
		public Person GetPerson(int id)
		{
			return _con.Table<Person>().FirstOrDefault(t => t.ID == id);
		}

		public void DeletePerson(int id)
		{
			_con.Delete<Person>(id);
		}
		public void AddPerson(string firstName, string lastName)
		{
			var newPerson = new Person
			{
				FirstName = firstName,
				LastName = lastName
			};
			_con.Insert(newPerson);
		}

	}
}
