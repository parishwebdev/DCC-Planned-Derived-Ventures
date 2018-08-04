using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DCC_Planned_Derived_Ventures.Models;
using Microsoft.AspNet.Identity;

namespace DCC_Planned_Derived_Ventures.Controllers
{
    public class ItinerariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Itineraries
        public ActionResult Index()
        {
            return View(db.Itineraries.ToList());
        }

        // GET: Itineraries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);



            var itinAddToSpecficItin = db.ItineraryAddresses.Where(ia => ia.ItineraryId == itinerary.ID);


            foreach (var ia in itinAddToSpecficItin)
            {
                var address = db.Addresses.Where(ad => ad.ID == ia.AddressId);
                itinerary.Addresses = address;
            }



            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // GET: Itineraries/Create
        public ActionResult Create(int DestinationId)
        {
            Itinerary model = new Itinerary();
            model.DestinationId = DestinationId;
            model.AspNetUserId = User.Identity.GetUserId();
            return View(model);
        }

        // POST: Itineraries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,MilesAroundRoute,DestinationId,AspNetUserId")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                

                db.Itineraries.Add(itinerary);
                db.SaveChanges();

               InsertStartAndStopIdsToNewIntineraryAddress(itinerary);
                


                
                return RedirectToAction("Index");
            }

            return View(itinerary);
        }


       private void InsertStartAndStopIdsToNewIntineraryAddress(Itinerary itinerary)
        {
            ItineraryAddresses itineraryAddressDestination = new ItineraryAddresses();
            itineraryAddressDestination.AddressId = itinerary.DestinationId;
            itineraryAddressDestination.ItineraryId = itinerary.ID;
            
            

            db.ItineraryAddresses.Add(itineraryAddressDestination);
            db.SaveChanges();
           
        }

        // GET: Itineraries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // POST: Itineraries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,MilesAroundRoute,StartAddressID,DestinationId,AspNetUserId")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itinerary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itinerary);
        }

        // GET: Itineraries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itineraries.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // POST: Itineraries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Itinerary itinerary = db.Itineraries.Find(id);
            db.Itineraries.Remove(itinerary);
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
