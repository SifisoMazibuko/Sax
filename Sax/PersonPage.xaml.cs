using System;
using System.Collections.Generic;
using Sax.DbConnection;
using Xamarin.Forms;

namespace Sax
{
    public partial class PersonPage : ContentPage
    {
		private createDatabase _database;
        private PersonPage _parent;
		public ListView _list;

		public PersonPage(createDatabase database)
		{
			//InitializeComponent();
			_database = database;
			this.Title = "List of Names";
			var person = _database.GetPerson();

			_list = new ListView();
			_list.ItemsSource = person;
			_list.ItemTemplate = new DataTemplate(typeof(TextCell));
            _list.ItemTemplate.SetBinding(TextCell.TextProperty, "FirstName");
            _list.ItemTemplate.SetBinding(TextCell.DetailProperty, "LastName");

			//toolbar 
			var toolbarItem = new ToolbarItem
			{
				Text = "Add Person",
				Command = new Command(() => Navigation.PushAsync(new CreateSQLDbPage(this, _database)))
			};

			ToolbarItems.Add(toolbarItem);
			//Content = _list;

            var button = new Button { 
                Text = "Clear List"
            };
            var prsn = new Person();
            button.Clicked += (sender,args) => {

                //_list.ItemsSource = null;

                _database.DeleteAll();
                _list.ItemsSource = _database.GetPerson();
                //prsn.FirstName = string.Empty;
               // prsn.LastName = string.Empty;
                
            };
            var stack = new StackLayout
            {
                Children = {
                    _list,
                    button
                }
            };
            Content = stack;

		}

		public void refreshList()
		{
			_list.ItemsSource = _database.GetPerson();
		}

	}
}
