using Microsoft.AspNetCore.Mvc;
using Infrastructure.Entities;
using Infrastructure.Repositories.Interfaces;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository repository;

        public ProductController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var products = repository.GetAll();
            return View(products);
        }

        public IActionResult Edit(string sifra)
        {
            var product = repository.GetBySifra(sifra);
            if (product == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                bool result = repository.Update(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                bool result = repository.Create(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(string sifra)
        {
            var product = repository.GetBySifra(sifra);
            if (product == null)
            {
                return RedirectToAction(nameof(Index));
            }

            bool result = repository.Delete(sifra);
            return RedirectToAction(nameof(Index));
        }
    }
}
