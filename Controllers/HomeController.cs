using MeetingApp.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var UserCount = ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            int Saat = DateTime.Now.Hour;
            ViewBag.selamlama = Saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Emrah";
            var meetingInfo = new MeetingInfo
            {
                Id = 1,
                Location = "Batman Kültür Merkezi",
                Date = new DateTime(2025, 01, 10, 20, 0, 0),
                NumberOfPeople = UserCount,
            };

            return View(meetingInfo);
        }
        public string List()
        {
            return "Home/List";
        }
    }


}