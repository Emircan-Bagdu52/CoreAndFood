using CoreAndFood.Data.Models;
using CoreAndFood.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index()
        {

            var ct = categoryRepository.TList();
            return View(ct);
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(category);
            return RedirectToAction("Index");
        }
        public IActionResult CategoryGet(int id)
        {
            var x=categoryRepository.TGet(id);
            Category ct = new Category()
            {
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                CategoryID = x.CategoryID
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            var x = categoryRepository.TGet(category.CategoryID);

            x.CategoryName = category.CategoryName;
            x.CategoryDescription = category.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var x=categoryRepository.TGet(id);
            x.Status = false;
            categoryRepository.TUpdate(x);

          return RedirectToAction("Index");
        }
    }
}
