using System.Web.Mvc;
using DynamicForm.Models;

namespace DynamicForm.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetForm()
        {
            return PartialView("_Form", new FormViewModel());
        }

        [HttpPost]
        public ActionResult SaveForm(FormViewModel formviewModel)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Form", formviewModel);
            }
            return Json(new { success = true });
        }
    }
}
