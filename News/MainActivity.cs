using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Views.InputMethods;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;
using Java.Lang;
using News.Adapter;
using News.GetterSetter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using static Android.Icu.Text.Transliterator;
using static Android.Views.KeyCharacterMap;
using static Google.Android.Material.Tabs.TabLayout;

namespace News
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppThemeNoBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public static SwipeRefreshLayout swipeRefreshLayout;
        public static List<listnewsgetset> recyclelist = new List<listnewsgetset>();
        public static RecyclerView mRecyclerView;
        public static newsadapter mAdapter;
        public static string country;
        public static TextView edtcategory, edtcountry;
        public static ImageView imgcategory, imgcountry;
        public static string whoselect = "";
        public static int pagenumber = 1;
        public static int totalview = 0;
        public static ProgressBar progressbarinfinity;
        public static EditText txtsearch;
        public static Button btnclear, btncari;
        public static LinearLayout llpb;
        public static Activity context;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            context = this;

            txtsearch = FindViewById<EditText>(Resource.Id.edtsearch);

            txtsearch.EditorAction += EditTextOnEditorAction;

            btnclear = FindViewById<Button>(Resource.Id.btnclear);

            btncari = FindViewById<Button>(Resource.Id.btncari);

            btncari.Click += delegate
            {
                GetData();
            };

            pagenumber = 1;
            totalview = 0;

            progressbarinfinity = FindViewById<ProgressBar>(Resource.Id.progressbarinfinity);

            llpb = FindViewById<LinearLayout>(Resource.Id.llpb);

            edtcategory = FindViewById<TextView>(Resource.Id.edtcategory);

            edtcountry = FindViewById<TextView>(Resource.Id.edtcountry);

            imgcategory = FindViewById<ImageView>(Resource.Id.imgcategory);

            imgcountry = FindViewById<ImageView>(Resource.Id.imgcountry);

            edtcategory.Click += delegate
            {
                whoselect = "1";

                OpenCategory();
            };

            edtcountry.Click += delegate
            {
                whoselect = "2";

                OpenCountry();
            };

            imgcategory.Click += delegate
            {
                whoselect = "1";

                OpenCategory();
            };

            imgcountry.Click += delegate
            {
                whoselect = "2";

                OpenCountry();
            };


            btnclear.Click += delegate
            {
                txtsearch.Text = "";
            };

            txtsearch.AfterTextChanged += (sender, args) =>
            {
                if (txtsearch.Text.Length > 0)
                {
                    btnclear.Visibility = ViewStates.Visible;
                }
                else
                {
                    btnclear.Visibility = ViewStates.Gone;
                }
            };

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mRecyclerView.SetLayoutManager(new LinearLayoutManager(this));
            mAdapter = new newsadapter(recyclelist);
            mAdapter.ItemClick += OnItemClick;
            mRecyclerView.SetAdapter(mAdapter);

            //swipeRefreshLayout = FindViewById<SwipeRefreshLayout>(Resource.Id.swipeRefreshLayout);

            //swipeRefreshLayout.Refresh += delegate (object sender, System.EventArgs e)
            //{
            //    new LoadData().ExecuteOnExecutor(AsyncTask.ThreadPoolExecutor);

            //    swipeRefreshLayout.Refreshing = false;
            //};

            GetIP();

            if (mRecyclerView != null)
            {
                mRecyclerView.HasFixedSize = true;

                var layoutManager = new LinearLayoutManager(this);

                var onScrollListener = new XamarinRecyclerViewOnScrollListener(layoutManager);
                onScrollListener.LoadMoreEvent += (object sender, int val, EventArgs e) =>
                {

                    if (totalview != val)
                    {
                        totalview = val;
                        pagenumber = pagenumber + 1;

                        progressbarinfinity.Visibility = ViewStates.Visible;

                        DataTable dttemp = new DataTable();
                        services.BasicHttpBinding_IService1 MyClient = new services.BasicHttpBinding_IService1();
                        services.Temp tempdata = new services.Temp();
                        tempdata = MyClient.SP_GetNews(edtcountry.Text, edtcategory.Text, txtsearch.Text, pagenumber.ToString());
                        dttemp = tempdata.Temptable;
                        

                        if (dttemp.Rows.Count > 0)
                        {
                            for (int i = 0; i < dttemp.Rows.Count; i++)
                            {
                                recyclelist.Add(new listnewsgetset(dttemp.Rows[i][0].ToString(), dttemp.Rows[i][1].ToString(), dttemp.Rows[i][2].ToString(), dttemp.Rows[i][4].ToString(), dttemp.Rows[i][5].ToString(), dttemp.Rows[i][6].ToString()));
                            }

                        }

                        progressbarinfinity.Visibility = ViewStates.Gone;

                        mAdapter.NotifyDataSetChanged();
                    }

                };

                mRecyclerView.AddOnScrollListener(onScrollListener);
                mRecyclerView.SetLayoutManager(layoutManager);
                mAdapter = new newsadapter(recyclelist);
                mAdapter.ItemClick += OnItemClick;
                mRecyclerView.SetAdapter(mAdapter);
            }
        }
        private void EditTextOnEditorAction(object sender, TextView.EditorActionEventArgs e)
        {
            txtsearch.SetSelection(txtsearch.Length());

        }
        public static void GetData()
        {
            pagenumber = 1;
            totalview = 0;

            DataTable dttempx = new DataTable();
            services.BasicHttpBinding_IService1 MyClientx = new services.BasicHttpBinding_IService1();
            services.Temp tempdatax = new services.Temp();
            tempdatax = MyClientx.SP_GetNews(edtcountry.Text, edtcategory.Text, txtsearch.Text, "1");
            dttempx = tempdatax.Temptable;

            MainActivity.recyclelist.Clear();

            if (dttempx.Rows.Count > 0)
            {
                for (int i = 0; i < dttempx.Rows.Count; i++)
                {
                    MainActivity.recyclelist.Add(new listnewsgetset(dttempx.Rows[i][0].ToString(), dttempx.Rows[i][1].ToString(), dttempx.Rows[i][2].ToString(), dttempx.Rows[i][4].ToString(), dttempx.Rows[i][5].ToString(), dttempx.Rows[i][6].ToString()));

                }

            }

            MainActivity.mAdapter.NotifyDataSetChanged();

            MainActivity.mRecyclerView.SmoothScrollToPosition(0);
        }
        public static void OpenCountry()
        {
            Dialog dialogmore = new Dialog(context, Resource.Style.BottomSheetDialog);
            dialogmore.RequestWindowFeature((int)WindowFeatures.NoTitle);
            dialogmore.SetContentView(Resource.Layout.data);
            dialogmore.SetCancelable(true);

            List<listdatagetset> recyclelist = new List<listdatagetset>();
            RecyclerView mRecyclerView;
            dataadapter mAdapter;

            TextView txtcode, txtdesc;

            txtcode = dialogmore.FindViewById<TextView>(Resource.Id.txtcode);
            txtdesc = dialogmore.FindViewById<TextView>(Resource.Id.txtdesc);

            txtcode.Text = "Kode";
            txtdesc.Text = "Negara";

            mRecyclerView = (RecyclerView)dialogmore.FindViewById(Resource.Id.recyclerView);
            mRecyclerView.SetLayoutManager(new LinearLayoutManager(context));
            mAdapter = new dataadapter(recyclelist);
            mAdapter.ItemClick += OnItemClick;
            mAdapter.NotifyDataSetChanged();

            void OnItemClick(object sender, int position)
            {
                edtcountry.Text = recyclelist[position].getCode().ToUpper();

                GetData();

                dialogmore.Dismiss();
            }

            DataTable dttemp = new DataTable();
            services.BasicHttpBinding_IService1 MyClient = new services.BasicHttpBinding_IService1();
            services.Temp tempdata = new services.Temp();
            tempdata = MyClient.SP_GetCountry();
            dttemp = tempdata.Temptable;


            recyclelist.Clear();


            if (dttemp.Rows.Count > 0)
            {
                for (int i = 0; i < dttemp.Rows.Count; i++)
                {
                    recyclelist.Add(new listdatagetset(dttemp.Rows[i][0].ToString(), dttemp.Rows[i][1].ToString()));
                }

                mAdapter.NotifyDataSetChanged();

                mRecyclerView.SetAdapter(mAdapter);

            }

            Window window = dialogmore.Window;
            WindowManagerLayoutParams wlp = window.Attributes;

            wlp.Gravity = GravityFlags.Center;
            window.Attributes = wlp;
            dialogmore.Window.SetLayout(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.MatchParent);

            dialogmore.Show();
        }
        public static void OpenCategory()
        {
            Dialog dialogmore = new Dialog(context, Resource.Style.BottomSheetDialog);
            dialogmore.RequestWindowFeature((int)WindowFeatures.NoTitle);
            dialogmore.SetContentView(Resource.Layout.data);
            dialogmore.SetCancelable(true);

            List<listdatagetset> recyclelist = new List<listdatagetset>();
            RecyclerView mRecyclerView;
            dataadapter mAdapter;

            TextView txtcode, txtdesc;

            txtcode = dialogmore.FindViewById<TextView>(Resource.Id.txtcode);
            txtdesc = dialogmore.FindViewById<TextView>(Resource.Id.txtdesc);

            txtcode.Text = "Kode";
            txtdesc.Text = "Kategori";

            mRecyclerView = (RecyclerView)dialogmore.FindViewById(Resource.Id.recyclerView);
            mRecyclerView.SetLayoutManager(new LinearLayoutManager(context));
            mAdapter = new dataadapter(recyclelist);
            mAdapter.ItemClick += OnItemClick;
            mAdapter.NotifyDataSetChanged();

            void OnItemClick(object sender, int position)
            {
                edtcategory.Text = recyclelist[position].getCode();

                GetData();

                dialogmore.Dismiss();
            }

            DataTable dttemp = new DataTable();
            services.BasicHttpBinding_IService1 MyClient = new services.BasicHttpBinding_IService1();
            services.Temp tempdata = new services.Temp();
            tempdata = MyClient.SP_GetCategory();
            dttemp = tempdata.Temptable;


            recyclelist.Clear();

            if (dttemp.Rows.Count > 0)
            {
                for (int i = 0; i < dttemp.Rows.Count; i++)
                {
                    recyclelist.Add(new listdatagetset(dttemp.Rows[i][0].ToString(), dttemp.Rows[i][1].ToString()));
                }

                mAdapter.NotifyDataSetChanged();

                mRecyclerView.SetAdapter(mAdapter);

            }

            Window window = dialogmore.Window;
            WindowManagerLayoutParams wlp = window.Attributes;

            wlp.Gravity = GravityFlags.Center;
            window.Attributes = wlp;
            dialogmore.Window.SetLayout(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.MatchParent);

            dialogmore.Show();
        }
        void OnItemClick(object sender, int position)
        {
            Dialog dialogmore = new Dialog(this, Resource.Style.AppThemeNoBar);
            dialogmore.RequestWindowFeature((int)WindowFeatures.NoTitle);
            dialogmore.SetContentView(Resource.Layout.detailnews);
            dialogmore.SetCancelable(true);

            ProgressBar spinner = (ProgressBar)dialogmore.FindViewById(Resource.Id.progressBar1);
            WebView webView = (WebView)dialogmore.FindViewById(Resource.Id.webview);

            webView.Settings.JavaScriptEnabled = true;
            webView.Settings.BuiltInZoomControls = false;
            webView.Settings.SetSupportZoom(false);
            webView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            webView.ScrollbarFadingEnabled = false;

            webView.SetWebViewClient(new WebViewClient());

            view();

            void view()
            {
                webView.LoadUrl(recyclelist[position].geturl());
            }

            Window window = dialogmore.Window;
            WindowManagerLayoutParams wlp = window.Attributes;

            wlp.Gravity = GravityFlags.Center;
            window.Attributes = wlp;
            dialogmore.Window.SetLayout(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.MatchParent);

            dialogmore.Show();
        }
        public class DataList
        {
            public string cc { get; set; }
        }
        public class LoadData : AsyncTask
        {
            protected override void OnPreExecute()
            {


            }

            protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                try
                {
                    llpb.Visibility = ViewStates.Visible;
                    mRecyclerView.Visibility = ViewStates.Gone;

                    DataTable dttemp = new DataTable();
                    services.BasicHttpBinding_IService1 MyClient = new services.BasicHttpBinding_IService1();
                    services.Temp tempdata = new services.Temp();
                    tempdata = MyClient.SP_GetNews(edtcountry.Text,edtcategory.Text, txtsearch.Text, "1");
                    dttemp = tempdata.Temptable;


                    recyclelist.Clear();

                    if (dttemp.Rows.Count > 0)
                    {
                        for (int i = 0; i < dttemp.Rows.Count; i++)
                        {
                            recyclelist.Add(new listnewsgetset(dttemp.Rows[i][0].ToString(), dttemp.Rows[i][1].ToString(), dttemp.Rows[i][2].ToString(), dttemp.Rows[i][4].ToString(), dttemp.Rows[i][5].ToString(), dttemp.Rows[i][6].ToString()));

                        }

                    }
                }
                catch (System.Exception e)
                {

                }

                return null;
            }

            private View findViewById(object content)
            {
                throw new NotImplementedException();
            }

            protected override void OnPostExecute(Java.Lang.Object result)
            {

                llpb.Visibility = ViewStates.Gone;
                mRecyclerView.Visibility = ViewStates.Visible;

                mAdapter.NotifyDataSetChanged();
            }
        }
        public async static void GetIP()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync("https://api.myip.com");
                var resultString = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<DataList>(resultString);

                country = result.cc;

                edtcountry.Text = country;

                new LoadData().ExecuteOnExecutor(AsyncTask.ThreadPoolExecutor);

            }
            catch (System.Exception e)
            {

            }

        }
    }
}