using HotelLandonBlog.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelLandonBlog.UI.Controllers
{
    public  abstract class GeneriqueController <Tentity> : Controller
        
       
    {
        // GET: GeneriqueController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GeneriqueController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GeneriqueController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneriqueController/Create
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

        // GET: GeneriqueController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GeneriqueController/Edit/5
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

        // GET: GeneriqueController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneriqueController/Delete/5
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
