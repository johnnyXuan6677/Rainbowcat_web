using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rainbowcat_web.Views.MVC
{
   
    public class Index9Model : PageModel
    {

        public string Result { get; set; }
        public void OnGet()
        {
            if (Request.Method != "POST")
            {
                Result = "第一次載入頁面（非 POST 請求）。";
            }
        }

        public void OnPost()
        {
            if (Request.Method == "POST")
            {
                Result = "提交表單後的回傳（POST 請求）。";
            }
        }
    }
}
