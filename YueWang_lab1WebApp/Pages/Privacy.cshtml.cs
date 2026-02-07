using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace YueWang_lab1WebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
            ViewData["TimeStamp"] = dateTime;
        }
    }

}
