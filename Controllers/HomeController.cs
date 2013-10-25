using System.Web.Mvc;

namespace CarterJK.Controllers
{
    public class HomeController : Controller
    {
        #region Methods (7) 

        // Public Methods (7) 

        public ActionResult Index(string viewName)
        {
            return View(viewName);
        }

        #endregion Methods 
    }
}