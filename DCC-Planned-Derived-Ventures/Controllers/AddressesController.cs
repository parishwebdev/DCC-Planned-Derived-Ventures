using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DCC_Planned_Derived_Ventures.Models;

namespace DCC_Planned_Derived_Ventures.Controllers
{
    public class AddressesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Addresses
        public ActionResult Index()
        {
            var addresses = db.Addresses.Include(a => a.City).Include(a => a.State).Include(a => a.ZipCode);
            return View(addresses.ToList());
        }

        // GET: Addresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = db.Addresses.Find(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // GET: Addresses/Create
        public ActionResult Create()
        {
            ViewBag.StateId = new SelectList(db.USStates, "ID", "abbrev");
            return View();
        }

        // POST: Addresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AddressLine,CityId,ZipId,StateId")] Address address)
        {
            if (ModelState.IsValid)
            {



                db.Addresses.Add(address);
                db.SaveChanges();
                return RedirectToAction("Create","Itineraries", new { DestinationId = address.ID });
            }

            ViewBag.CityId = new SelectList(db.Cities, "ID", "name", address.CityId);
            ViewBag.StateId = new SelectList(db.USStates, "ID", "abbrev", address.StateId);
            ViewBag.ZipId = new SelectList(db.Zips, "ID", "ZipCode", address.ZipId);
            return View(address);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string City, int Zipcode,[Bind(Include = "ID,AddressLine,StateId")] Address address)
        {
            if (ModelState.IsValid)
            {
                if (db.Cities.Any(c => c.name == City))
                {
                    City city = db.Cities.Where(c => c.name == City).Single();
                    address.CityId = city.ID;
                }
                if (db.Zips.Any(z => z.ZipCode == Zipcode))
                {
                    Zip zip = db.Zips.Where(z => z.ZipCode == Zipcode).Single();
                    address.ZipId = zip.ID;
                }
                else
                {
                    InsertCity(City);
                    InsertZip(Zipcode);

                    City city = db.Cities.Where(c => c.name == City).Single();
                    address.CityId = city.ID;

                    Zip zip = db.Zips.Where(z => z.ZipCode == Zipcode).Single();
                    address.ZipId = zip.ID;
                }

                db.Addresses.Add(address);
                db.SaveChanges();
                return RedirectToAction("Create", "Itineraries", new { DestinationId = address.ID });
            }
            
            ViewBag.StateId = new SelectList(db.USStates, "ID", "abbrev", address.StateId);
            return View(address);
        }

        private void InsertCity(string CityName)
        {
            City city = new City();
            city.name = CityName;

            db.Cities.Add(city);
            db.SaveChanges();

        }
        private void InsertZip(int ZipCode)
        {
            Zip zip = new Zip();
            zip.ZipCode = ZipCode;

            db.Zips.Add(zip);
            db.SaveChanges();
        }


        // GET: Addresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = db.Addresses.Find(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(db.Cities, "ID", "name", address.CityId);
            ViewBag.StateId = new SelectList(db.USStates, "ID", "abbrev", address.StateId);
            ViewBag.ZipId = new SelectList(db.Zips, "ID", "ID", address.ZipId);
            return View(address);
        }

        // POST: Addresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AddressLine,CityId,ZipId,StateId")] Address address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(address).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(db.Cities, "ID", "name", address.CityId);
            ViewBag.StateId = new SelectList(db.USStates, "ID", "abbrev", address.StateId);
            ViewBag.ZipId = new SelectList(db.Zips, "ID", "ID", address.ZipId);
            return View(address);
        }

        // GET: Addresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = db.Addresses.Find(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Address address = db.Addresses.Find(id);
            db.Addresses.Remove(address);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
