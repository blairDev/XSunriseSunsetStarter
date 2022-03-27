using Xamarin.Forms;

/// <summary>
/// Name:
/// File:
/// Project:
/// Revision Date:
/// </summary>
namespace XSunriseSunset
{
    public partial class App : Application
    {

        public static string DatabaseLocation = string.Empty;
        public static Location loc;

        /// <summary>
        /// 
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbLocation"></param>
        public App(string dbLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            DatabaseLocation = dbLocation;
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
