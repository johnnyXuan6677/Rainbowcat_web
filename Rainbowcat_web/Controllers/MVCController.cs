using Microsoft.AspNetCore.Mvc;
using System.Web.WebPages;
using System.Web.Razor;
using System.Web;




namespace Rainbowcat_web.Controllers
{
    public class MVCController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Index2()
        {
            //Models.Class1 class1 = new Models.Class1();
            //class1.UserName = "johnny";


            Models.Class1 class1 = new Models.Class1
            {
                UserName = "johnny"
            };
            


            return View(class1);
            //return Content("XXXXXXD");
        }


        public IActionResult Index3()
        {
            List<Models.Class1> myList = new List<Models.Class1>
            {
                new Models.Class1 {UserName = "(5). ASP.NET",PersonName = "owen",PersonSex ="M",PersonMobilePhone="0952632154"},
                new Models.Class1 {UserName = "(6). Web Form",PersonName = "andy",PersonSex ="M",PersonMobilePhone="09414112154"},
                new Models.Class1 {UserName = "(7). MVC",PersonName = "johnny",PersonSex ="M",PersonMobilePhone="095133333174"},
                new Models.Class1 {UserName = "(8). ASP.NET 專案實務",PersonName = "jeft",PersonSex ="F",PersonMobilePhone="096634518"}
            };
             return View(myList);
        }



        public ActionResult Index6() {
            
            return View();
        }

        public ActionResult Index7()
        {
            return View();
        }

        public ActionResult Index9() {
            
            
            return View();
        }

        public IActionResult First_page()
        {
            return View("/Views/MVC/first_page.cshtml");
        }


        //多行註解ctrl k + ctrl c
        //解除ctrl k + ctrl u
        //protected override void HandleUnknownAction(string actionname)
        //{
        //    response.redirect(actionname);
        //    base.HandleUnknownAction(actionname);
        //}

    }
}
