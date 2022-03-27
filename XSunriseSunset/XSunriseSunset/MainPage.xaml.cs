using SQLite;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

/// <summary>
/// Name:
/// File:
/// Project:
/// Revision Date:
/// </summary>
namespace XSunriseSunset
{
    public partial class MainPage : ContentPage
    {
        public static List<Location> myLocations = new List<Location>();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<Location> myLocations = new List<Location>();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                try
                {
                    conn.CreateTable<Location>(); //create if it doesn't exist
                    myLocations = conn.Table<Location>().ToList();
                }
                catch(Exception ex)
                {
                    _ = DisplayAlert("Error", "No response from SQLite Database - " + ex.Message, "OK");
                }
                
            }                                  

            lstLocations.ItemsSource = myLocations;
        }

        private void lstLocations_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Location loc = (Location)e.Item;
            App.loc = loc;
            Navigation.PushAsync(new SunriseSunset());
        }

        private void btnAddCity_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddCity());
        }
    }
}
