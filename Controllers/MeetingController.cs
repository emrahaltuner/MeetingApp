
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                Repository.CreateUser(model);
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }

        }
        public IActionResult List()
        {
            //
            var users = Repository.Users;
            return View(users);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}