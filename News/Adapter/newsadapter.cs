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
    public class newsadapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick, ItemLongClick;
        List<listnewsgetset> recyclelist;

        public newsadapter(List<listnewsgetset> Recyclelist)
        {
            this.recyclelist = Recyclelist;
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                     Inflate(Resource.Layout.listnews, parent, false);

            RecycleViewNews vh = new RecycleViewNews(itemView, OnClick);
            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

            RecycleViewNews vh = holder as RecycleViewNews;

            vh.txttitle.Text = recyclelist[position].gettitle();

            vh.txtsource.Text = recyclelist[position].getauthor();

            vh.txtpublished.Text = recyclelist[position].getpublished();

            if (recyclelist[position].geturlimage() != "")
            {
                Glide.With(Application.Context).Load(recyclelist[position].geturlimage()).Apply(RequestOptions.SkipMemoryCacheOf(true)).Apply(RequestOptions.DiskCacheStrategyOf(DiskCacheStrategy.None)).Apply(RequestOptions.SignatureOf(new ObjectKey(position))).Into(vh.imgnews);
            }

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
    public class RecycleViewNews : RecyclerView.ViewHolder
    {
        public int count = 0;
        public TextView txttitle { get; private set; }
        public TextView txtsource { get; private set; }
        public TextView txtpublished { get; private set; }
        public ImageView imgnews { get; private set; }
        public RecycleViewNews(View itemView, Action<int> listener) : base(itemView)
        {
            txttitle = itemView.FindViewById<TextView>(Resource.Id.txttitle);
            txtsource = itemView.FindViewById<TextView>(Resource.Id.txtsource);
            txtpublished = itemView.FindViewById<TextView>(Resource.Id.txtpublished);
            imgnews = itemView.FindViewById<ImageView>(Resource.Id.imgnews);

            itemView.Click += (sender, e) =>
            {
                listener(base.LayoutPosition);
            };
          
        }
    }
}