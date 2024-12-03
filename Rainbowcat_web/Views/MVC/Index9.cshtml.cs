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
                Result = "�Ĥ@�����J�����]�D POST �ШD�^�C";
            }
        }

        public void OnPost()
        {
            if (Request.Method == "POST")
            {
                Result = "������᪺�^�ǡ]POST �ШD�^�C";
            }
        }
    }
}
