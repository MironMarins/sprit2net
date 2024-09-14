using Microsoft.AspNetCore.Mvc;
using ApplicationCP2.Models;
using ApplicationCP2.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ApplicationCP2.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Cliente.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente newCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Add(newCliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newCliente);
        }

        public IActionResult Edit(int id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente editedCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(editedCliente).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(editedCliente);
        }

        public IActionResult Delete(int id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
