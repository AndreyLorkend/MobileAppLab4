using System;
using System.IO;
using Xamarin.Forms;

namespace MobileAppLab4
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";
        public static StudentsRepository database;
        public static StudentsRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new StudentsRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
