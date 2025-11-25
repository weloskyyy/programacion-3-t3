using Microsoft.AspNetCore.Mvc;
using CRUDT3.Data;
using CRUDT3.Models;
using System.Linq;

namespace CRUDT3.Controllers
{
    public class ContactosController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeDb.Contactos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contactomodel contacto)
        {
            contacto.IdContacto = FakeDb.Contactos.Max(c => c.IdContacto) + 1;
            FakeDb.Contactos.Add(contacto);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var contacto = FakeDb.Contactos.FirstOrDefault(c => c.IdContacto == id);
            return View(contacto);
        }

        [HttpPost]
        public IActionResult Edit(Contactomodel contacto)
        {
            var item = FakeDb.Contactos.FirstOrDefault(c => c.IdContacto == contacto.IdContacto);

            item.Nombre = contacto.Nombre;
            item.Telefono = contacto.Telefono;
            item.Correo = contacto.Correo;

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var contacto = FakeDb.Contactos.FirstOrDefault(c => c.IdContacto == id);
            if (contacto == null)
                return NotFound();

            return View(contacto);
        }

        public IActionResult Delete(int id)
        {
            var contacto = FakeDb.Contactos.FirstOrDefault(c => c.IdContacto == id);
            return View(contacto);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var contacto = FakeDb.Contactos.FirstOrDefault(c => c.IdContacto == id);
            FakeDb.Contactos.Remove(contacto);
            return RedirectToAction("Index");
        }
    }
}
