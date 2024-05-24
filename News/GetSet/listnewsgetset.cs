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
using Javax.Crypto.Spec;

namespace News.GetterSetter
{
    public class listnewsgetset
    {
        public string source;
        public string author;
        public string title;
        public string url;
        public string urlimage;
        public string published;
        public listnewsgetset()
        {

        }
        public listnewsgetset(string psource, string pauthor, string ptitle, string purl, string purlimage, string ppublished)
        {
            this.source = psource;
            this.author = pauthor;
            this.title = ptitle;
            this.url = purl;
            this.urlimage = purlimage;
            this.published = ppublished;
        }
        public string getsource() { return source; }
        public void setsource(string source) { this.source = source; }

        public string getauthor() { return author; }
        public void setauthor(string author) { this.author = author; }

        public string gettitle() { return title; }
        public void settitle(string title) { this.title = title; }

        public string geturl() { return url; }
        public void seturl(string url) { this.url = url; }

        public string geturlimage() { return urlimage; }
        public void seturlimage(string urlimage) { this.urlimage = urlimage; }

        public string getpublished() { return published; }
        public void setpublished(string published) { this.published = published; }

    }
}