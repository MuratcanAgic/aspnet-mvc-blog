using App.Persistence.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.ViewComponents
{
  public class SliderViewComponent : ViewComponent
  {
    private readonly AppDbContext _db;

    public SliderViewComponent(AppDbContext db)
    {
      _db = db;
    }
    public IViewComponentResult Invoke()
    {
      //var postList = _db.Post.Include(p => p.CategoryPosts).ToList();
      var postList = _db.Post.Include(p => p.PostImage).Include(p => p.CategoryPosts).ToList();
      return View(postList);
    }
  }
}
