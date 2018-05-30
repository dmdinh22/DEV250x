using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;

namespace ProductManager.Controllers {
    public class ProductTypeController : Controller {
        public IActionResult Index() {
            var types = DataSource.GetProductTypes();
            return View(types);
        }

        // other actions
    }
}