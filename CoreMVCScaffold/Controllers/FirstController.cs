using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCScaffold.Controllers
{
    public class FirstController : Controller
    {
        // GET: FirstController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FirstController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FirstController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FirstController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FirstController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FirstController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FirstController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FirstController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
