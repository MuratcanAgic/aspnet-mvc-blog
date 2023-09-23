using App.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class CategoryController : Controller
	{

		//private readonly AppDbContext _db;
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IActionResult Index(int id, int page)
		{
			return View();
		}
		public IActionResult Search(string searchString)
		{
			if (searchString == null)
				return RedirectToAction(nameof(Index));

			var posts = _categoryService.GetPostsBySearch(searchString);

			if (posts is null)
				return RedirectToAction(nameof(Index));

			return View(posts);

		}
		[HttpGet]
		public IActionResult CategoryIndex(int Id)
		{
			if (Id == 0)
				return RedirectToAction(nameof(Index));

			var posts = _categoryService.GetPostsByCategoryIndex(Id);

			if (posts is null)
				return RedirectToAction(nameof(Index));

			return View(posts);
		}
	}
}
