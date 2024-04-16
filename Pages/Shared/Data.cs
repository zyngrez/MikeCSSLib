using System.Data;
using System.Runtime.CompilerServices;

namespace MikeCSSLib.Pages.Shared
{
    public class tag
    {
        public string tagname = "";
        public string className = "";
        public string id = "";
        public string content = "";
        public tag(string _tagname)
        {
            tagname= _tagname;
        }
        public tag(string _tagname,string _classname)
        {
            tagname = _tagname;
            className = _classname;
        }
        public tag(string _tagname, string _classname,string _id)
        {
            tagname = _tagname;
            className = _classname;
            id = _id;
        }
        override public string ToString()
        {
            string ret = string.Format($"<{0} class={1} id={2}>{3}</{0}>",tagname,className,id,content);    
        return ret;
        }
    }
    static public class Data
    {
        public static string GetTable(DataTable dt)
        {
            string body = "";
            tag container = new tag("div","collapseTable");
            int rc = 0;
            int cc = 0;
            foreach(DataColumn col in dt.Columns)
            {
                body += string.Format("<div class=\"drHdr drCol{0}\">{1}</div>", cc,col.ColumnName);
                cc += 1;
            }
            foreach (DataRow dr in dt.Rows) {
                cc = 0;
                foreach (object? value in dr.ItemArray)
                {
                    body += string.Format("<div class=\"drRow{0} drCol{1}\">{2}</div>",rc, cc,value??"".ToString());
                    cc += 1;

                }
                rc += 1;
            }
            container.content = body;
            return container.ToString();
        }
    }
}
