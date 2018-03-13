using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListViewApp
{
    [Activity(Label = "ListViewApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<Data> Items;
        private ListView ListView1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ListView1 = FindViewById<ListView>(Resource.Id.listView1);

            
            Items = new List<Data>();
            Items.Add(new Data() { image = Resource.Drawable.auto5, txtTootja = "Ford", txtModel = "Focus", txtKW = "350kW" });
            Items.Add(new Data() { image = Resource.Drawable.auto2, txtTootja = "Opel", txtModel = "Astra", txtKW = "290kW" });
            Items.Add(new Data() { image = Resource.Drawable.auto3, txtTootja = "Ford", txtModel = "Fiesta", txtKW = "223kW" });
            Items.Add(new Data() { image = Resource.Drawable.auto4, txtTootja = "Mersu", txtModel = "A150", txtKW = "99kW" });
            Items.Add(new Data() { image = Resource.Drawable.auto5, txtTootja = "Tesla", txtModel = "Model S", txtKW = "560kW" });
            Items.Add(new Data() { image = Resource.Drawable.auto6, txtTootja = "Gen. Tootja 1", txtModel = "Gen. Model 1", txtKW = "Gen. Power1" });
            Items.Add(new Data() { image = Resource.Drawable.auto7, txtTootja = "Gen. Tootja 2", txtModel = "Gen. Model 2", txtKW = "Gen. Power2" });
            Items.Add(new Data() { image = Resource.Drawable.auto8, txtTootja = "Gen. Tootja 3", txtModel = "Gen. Model 3", txtKW = "Gen. Power3" });
            Items.Add(new Data() { image = Resource.Drawable.auto9, txtTootja = "Gen. Tootja 4", txtModel = "Gen. Model 4", txtKW = "Gen. Power4" });
            Items.Add(new Data() { image =  Resource.Drawable.auto10, txtTootja = "Gen. Tootja 5", txtModel = "Gen. Model 5", txtKW = "Gen. Power5" });

            ListViewAdapter adapter = new ListViewAdapter(this, Items);

            ListView1.Adapter = adapter;
        }
    }
}

