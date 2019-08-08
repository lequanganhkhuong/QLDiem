using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockProject.Models;

namespace MockProject.Controllers
{
   
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password, string returnUrl)
        {
         
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.Message = "Username or password cannot be empty";
                return RedirectToAction(nameof(Index));
            }

            var emp = _context.Users
                .Where(x => x.Username.Equals(username) && x.Password.Equals(password)).Include(x => x.Role)
                .FirstOrDefault();
            if (emp == null)
            {
                ViewBag.Message = "Wrong username or password";
                return RedirectToAction(nameof(Index));
            }
            else if (!emp.IsActive)
            {
                ViewBag.Message = "This user is blocked";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, emp.Id.ToString()),
                    new Claim("Username", emp.Name),
                    new Claim(ClaimTypes.Role, emp.Role.Name),
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, principal);

                if (emp.RoleId == 1)
                {
                    return RedirectToAction("Index", "Home", new {area = "Admin"});
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
                

            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
