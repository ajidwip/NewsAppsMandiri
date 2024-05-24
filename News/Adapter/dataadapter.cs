using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Com.Bumptech.Glide;
using Com.Bumptech.Glide.Load.Engine;
using Com.Bumptech.Glide.Request;
using Com.Bumptech.Glide.Signature;
using News.GetterSetter;
using Xamarin.Essentials;

namespace News.Adapter
{
    class dataadapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick, ItemLongClick;
        List<listdatagetset> recyclelist;

        public dataadapter(List<listdatagetset> Recyclelist)
        {
            this.recyclelist = Recyclelist;
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                     Inflate(Resource.Layout.listdata, parent, false);

            RecycleViewData vh = new RecycleViewData(itemView, OnClick);
            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

            RecycleViewData vh = holder as RecycleViewData;

            vh.code.Text = recyclelist[position].getCode();

            vh.desc.Text = recyclelist[position].getDesc();

        }


        public override int ItemCount
        {
            get { return recyclelist == null ? 0 : recyclelist.Count; }
        }
        void OnClick(int position)
        {
            ItemClick(this, position);
        }
        void OnLongClick(int position)
        {
            ItemLongClick(this, position);
        }
    }
    public class RecycleViewData : RecyclerView.ViewHolder
    {
        public int count = 0;
        public TextView code { get; private set; }
        public TextView desc { get; private set; }
        public RecycleViewData(View itemView, Action<int> listener) : base(itemView)
        {
            code = itemView.FindViewById<TextView>(Resource.Id.code);
            desc = itemView.FindViewById<TextView>(Resource.Id.desc);

            itemView.Click += (sender, e) =>
            {
                listener(base.LayoutPosition);
            };
          
        }
    }
}