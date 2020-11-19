using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PO7.Models;

namespace PO7.Controllers
{
    public class ShootingController : Controller
    {
        private readonly po7DbContext _db;

        public ShootingController(po7DbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            List<ShootingResult> shooting = _db.ShootingResult.Include(x => x.gun).ToList();
            return View(shooting);
        }

        public IActionResult Add()
        {
            List<Gun> guns = _db.Gun.ToList();
            ViewBag.GunsList = guns;
            return View();
        }

        [HttpPost]
        public IActionResult Add(ShootingResult model)
        {

            if (ModelState.IsValid)
            {
                _db.ShootingResult.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);

        }

        public IActionResult Edit(int id)
        {
                        List<Gun> guns = _db.Gun.ToList();
            ViewBag.GunsList = guns;
            ShootingResult model = _db.ShootingResult.FirstOrDefault(x => x.id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ShootingResult model)
        {
            if (ModelState.IsValid)
            {
                ShootingResult gunToUpdate = _db.ShootingResult.FirstOrDefault(x => x.id == model.id);
                if (gunToUpdate is null)
                {
                    return RedirectToAction("Edit", new { id = model.id });
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
            ShootingResult gunToDelite = _db.ShootingResult.FirstOrDefault(x => x.id == id);
            if (gunToDelite is null)
            {
                return RedirectToAction("Edit", new { id = id });
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
