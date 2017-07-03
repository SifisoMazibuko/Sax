using System;
using SQLite.Net.Attributes;

namespace Sax
{
	public class Person
	{
		[PrimaryKey, AutoIncrement]
		public int ID
		{
			get;
			set;
		}
		public string FirstName
		{
			get;
			set;
		}
		public string LastName
		{
			get;
			set;
		}
		public override String ToString()
		{
			return string.Format("[Person: ID={0}, FirstName={1}, LastName={2}]" + ID, FirstName, LastName);
		}
        public Person()
        {
            
        }
	}
}
