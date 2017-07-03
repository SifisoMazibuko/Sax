using Sax.DbConnection;
using Xamarin.Forms;

namespace Sax
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GetPage();
        }
		public void GetPage()
		{
			var _database = new createDatabase();
			MainPage = new NavigationPage(new PersonPage(_database));
		}

		protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
