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

namespace News.GetterSetter
{
    public class listdatagetset
    {
        public string Code;
        public string Desc;
        public listdatagetset()
        {

        }
        public listdatagetset(string pCode, string pDesc)
        {
            this.Code = pCode;
            this.Desc = pDesc;
    }
        public string getCode() { return Code; }
        public void setCode(string Code) { this.Code = Code; }

        public string getDesc() { return Desc; }
        public void setDesc(string Desc) { this.Desc = Desc; }

    }
}