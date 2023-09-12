using App.Web.Mvc.Data;
using App.Web.Mvc.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
  public class AuthController : Controller
  {

    private readonly AppDbContext _db;
    public AuthController(AppDbContext db)
    {
      _db = db;
    }

    public IActionResult Register()
    {
      User user = new User();

      return View(user);
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
      if (user == null)
      {
        return View();
      }
      if (ModelState.IsValid)
      {
        _db.User.Add(user);
        _db.SaveChanges();
        return RedirectToAction("Index", "Home");
      }

      return View(user);
    }

    public IActionResult Login(string redirectUrl)
    {
      return View();
    }
    public IActionResult ForgotPassword()
    {
      return View();
    }

  }
}
