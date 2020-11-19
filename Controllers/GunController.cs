using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PO7.Models;

namespace PO7.Controllers
{
    public class GunController : Controller
    {
        private readonly po7DbContext _db;

        public GunController(po7DbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            List<Gun> guns = _db.Gun.ToList();
            return View(guns);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Gun model)
        {

            if (ModelState.IsValid)
            {
                _db.Gun.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);

        }

        public IActionResult Edit(int id)
        {
            Gun model = _db.Gun.FirstOrDefault(x => x.id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Gun model)
        {
            if (ModelState.IsValid)
            {
                Gun gunToUpdate= _db.Gun.FirstOrDefault(x => x.id == model.id);
                if(gunToUpdate is null)
                {
                    return RedirectToAction("Edit", new { id = model.id});
                }
                else
                {
                    gunToUpdate = model;
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }

            return View(model);
        }


        public IActionResult Delete(int id)
        {
            Gun gunToDelite = _db.Gun.FirstOrDefault(x => x.id == id);
            if(gunToDelite is null)
            {
                return RedirectToAction("Edit", new { id =id });
            }
            else
            {
                _db.Remove(gunToDelite);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
