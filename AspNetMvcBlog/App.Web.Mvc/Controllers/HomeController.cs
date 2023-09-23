using App.Persistence.Data;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Web.Mvc.Controllers
{
  public class HomeController : Controller
	{

		private readonly AppDbContext _db;


		public HomeController(AppDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
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