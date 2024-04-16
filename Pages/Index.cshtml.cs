using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
namespace MikeCSSLib.Pages
{
    public class IndexModel : PageModel

    {
        public DataTable dt;
        ElementReference ph;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            LoadData();
            ViewData["Data"] = dt;
        }
        public void LoadData()
        {
            dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("RecordName");
            dt.Columns.Add("RecordDescription");
            dt.Columns.Add("IsActive");
            dt.Rows.Add(new object[] { 1, "Tom", "Runner", "Y" });
            dt.Rows.Add(new object[] { 2, "Joe", "Runner", "N" });
            dt.Rows.Add(new object[] { 3, "Fred", "Flagger", "Y" });
            dt.Rows.Add(new object[] { 4, "Mark", "Referee", "Y" });

        }
    }
}
