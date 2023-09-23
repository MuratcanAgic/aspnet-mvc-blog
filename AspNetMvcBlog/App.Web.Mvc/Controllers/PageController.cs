using App.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class PageController : Controller
	{

		private readonly IPageService _pageService;

		public PageController(IPageService pageService)
		{
			_pageService = pageService;
		}

		public IActionResult Detail(int Id)
		{
			if (Id == 0)
				return RedirectToAction(nameof(Index));

			var pages = _pageService.GetAll();

			if (pages is null)
				return RedirectToAction(nameof(Index));

			return View(pages);
		}
	}
}
