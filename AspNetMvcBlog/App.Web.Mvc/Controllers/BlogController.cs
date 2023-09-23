using App.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class BlogController : Controller
	{


		private readonly IPostService _postService;

		public BlogController(IPostService postService)
		{

			_postService = postService;
		}

		public IActionResult Search(string query, int page)
		{
			return View();
		}

		public IActionResult Detail(int Id)
		{
			if (Id == 0)
				return RedirectToAction(nameof(Index));

			var post = _postService.GetById(Id);
			if (post is null)
				return RedirectToAction(nameof(Index));

			ViewBag.CategoryName = _postService.GetCategoryName(Id);
			return View(post);

		}

	}
}
