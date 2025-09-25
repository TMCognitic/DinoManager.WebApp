using DinoManager.WebApp.Domain.Queries;
using DinoManager.WebApp.Domain.Repositories;
using DinoManager.WebApp.Models.Forms;
using Microsoft.AspNetCore.Mvc;

namespace DinoManager.WebApp.Controllers
{
    public class DinoController : Controller
    {
        private readonly IDinoRepository _repository;

        public DinoController(IDinoRepository repository)
        {
            _repository = repository;
        }

        // GET: DinoController
        public ActionResult Index()
        {
            return View(_repository.Execute(new GetAllDinoQuery()).Select(d => new DisplayDinoForm(d)));
        }

        // GET: DinoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DinoController/Create
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

        // GET: DinoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DinoController/Edit/5
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

        // GET: DinoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DinoController/Delete/5
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
