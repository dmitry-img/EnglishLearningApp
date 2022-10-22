using EnglishLearning.Data;
using EnglishLearning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text;

namespace EnglishLearning.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == userLogin.Username);
            if(user != null)
            { 
                var byteArray = Encoding.ASCII.GetBytes(userLogin.Password);
                string encodedPassword = Convert.ToBase64String(byteArray);
                if(encodedPassword == user.Password)
                {
                    ViewData["user"] = user;
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(String.Empty, "Wrong Usernaem or Password");
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}