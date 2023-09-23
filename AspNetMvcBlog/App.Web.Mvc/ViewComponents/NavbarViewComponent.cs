using App.Persistence.Data;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
  public class NavbarViewComponent : ViewComponent
	{
		private readonly AppDbContext _db;

		public NavbarViewComponent(AppDbContext db)
		{
			_db = db;
		}

		public IViewComponentResult Invoke()
		{

			NavbarViewModel result = new NavbarViewModel();
			result.Categories = _db.Category.ToList();
			result.Pages = _db.Page.ToList();

			return View(result);
		}
	}
}
