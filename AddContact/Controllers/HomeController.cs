using AddContact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AddContact.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx) => context = ctx;


        public IActionResult Index()
        {
            var contacts=context.Contacts.OrderBy(c=>c.FirstName).ToList();
            return View(contacts);
        }
    }
}
