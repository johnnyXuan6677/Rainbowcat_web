using Microsoft.AspNetCore.Mvc;
using Rainbowcat_web.Models;
using System.Diagnostics;

namespace Rainbowcat_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public  IActionResult About()
        {
            return View();
        }

        public IActionResult Contact() 
        { 
            return View();
        }


        public ActionResult Index3() {

            ViewData["A"] = "(1). 字串A,我是ViewData[]";
            ViewBag.B = "(2). 字串B 我是ViewBag";
            TempData["C"] = "(3). 字串C。我是TempData{}";

            return View();
        }

        public ActionResult Index10()
        {
            return View();
        }

        public ActionResult Index11Create()
        {   // 搭配 Class1，做出新增（Create）的檢視畫面
            return View();
        }

        [ValidateAntiForgeryToken]   // 搭配檢視畫面（View）的Razor表單裡面，「@Html.AntiForgeryToken()」這句話以避免CSRF攻擊！！
        [HttpPost, ActionName("Index11Create")]    // ***重點！！刪除這一句話，會出錯！！***  完整寫法 [AcceptVerbs(HttpVerbs.Post)]
        public string Index11Create(Models.Class1 class1)
        {   // 搭配 Class1，做出新增（Create）功能
            try
            {
                if (!ModelState.IsValid)   // 驗證（Validation）。預計到「第五節課」會講到
                {
                    return "NOT ModelState.IsValid";
                }
                return "成功！！......您剛剛輸入的 UserName是：<font color=blue>" + class1.UserName + "</font>";
            }
            catch
            {
                return "Exception：失敗";
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}