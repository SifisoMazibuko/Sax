using System;
using System.Collections.Generic;
using Sax.DbConnection;
using Xamarin.Forms;

namespace Sax
{
    public partial class CreateSQLDbPage : ContentPage
    {
		private PersonPage _parent;
		private createDatabase _database;
		public CreateSQLDbPage()
		{
			InitializeComponent();
		}

		public CreateSQLDbPage(PersonPage parent, createDatabase database)
		{
			_parent = parent;
			_database = database;
			this.Title = "Add Person";

			var entryFirstName = new Entry
			{
				Placeholder = "Add Firstname"
			};
			var entryLastName = new Entry
			{
				Placeholder = "Add Surname"
			};
			var button = new Button
			{
				Text = "Add Person"
			};

			button.Clicked += async (sender, e) =>
		   {
			   var first = entryFirstName.Text;
			   var second = entryLastName.Text;
			   _database.AddPerson(first, second);
			   await Navigation.PopAsync();

                _parent.refreshList();
		   };
			var stack = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Spacing = 10,
				Children = {
					entryFirstName,
					entryLastName,
					button
				}

			};
			Content = stack;
		}

	}
}
