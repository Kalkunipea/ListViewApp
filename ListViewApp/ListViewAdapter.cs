using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewApp
{
    class ListViewAdapter : BaseAdapter<Data>
    {
        private List<Data> Items;
        private Context Context;

        public ListViewAdapter(Context context, List<Data> items)
        {
            Items = items;
            Context = context;

        }
        public override int Count
        {
            get {return Items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Data this[int position]
        {
            get { return Items[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row == null)
            {
                row = LayoutInflater.From(Context).Inflate(Resource.Layout.listviewr, null, false);
            }

           TextView txtTootja = row.FindViewById<TextView>(Resource.Id.txtTootja);
            txtTootja.Text = Items[position].txtTootja;

            TextView txtModel = row.FindViewById<TextView>(Resource.Id.txtModel);
            txtModel.Text = Items[position].txtModel;

            TextView txtKW = row.FindViewById<TextView>(Resource.Id.txtKW);
            txtKW.Text = Items[position].txtKW;

            ImageView Image = row.FindViewById<ImageView>(Resource.Id.imageView1);
            Image.SetImageResource(Items[position].image);

            return row;
        }

    }
}