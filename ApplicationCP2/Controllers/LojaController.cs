using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ApplicationCP2.Models;
using ApplicationCP2.Data;

namespace ApplicationCP2.Controllers
{
    public class LojaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LojaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Loja.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Loja loja)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loja);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(loja);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loja = _context.Loja.Find(id);
            if (loja == null)
            {
                return NotFound();
            }
            return View(loja);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Loja loja)
        {
            if (id != loja.IDLOJA)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loja);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LojaExists(loja.IDLOJA))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(loja);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loja = _context.Loja.Find(id);
            if (loja == null)
            {
                return NotFound();
            }

            return View(loja);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var loja = _context.Loja.Find(id);
            _context.Loja.Remove(loja);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool LojaExists(int id)
        {
            return _context.Loja.Any(e => e.IDLOJA == id);
        }
    }
}
