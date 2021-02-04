using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Services.Protocols;
using eZdravaIshrana_API.Models;

namespace eZdravaIshrana_API.Controllers
{
    public class SortaProizvodaController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/SortaProizvoda editetededed
        [HttpGet]
        [Route("api/SortaProizvoda/{ID}")]
        public IQueryable<SortaProizvoda> GetSortaProizvoda(int ID)
        {
            return db.SortaProizvoda.Where(x=>x.VrstaID == ID).OrderBy(x => x.Naziv);
        }

        [HttpGet]
        [Route("api/SortaProizvoda/SortaProizvodahlp/{ID}")]
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult SortaProizvodahlp(int id)
        {
            SortaProizvoda sorta = db.SortaProizvoda.Find(id);
            if (sorta == null)
            {
                return NotFound();
            }

            return Ok(sorta);
        }


        [HttpGet]
        public IQueryable<SortaProizvoda> GetSortaProizvoda()
        {
            return db.SortaProizvoda.OrderBy(x => x.Naziv);
        }

        // POST: api/SortaProizvoda
        [ResponseType(typeof(SortaProizvoda))]
        public IHttpActionResult PostSortaProizvoda(SortaProizvoda sortaProizvoda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SortaProizvoda.Add(sortaProizvoda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sortaProizvoda.SortaID }, sortaProizvoda);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SortaProizvodaExists(int id)
        {
            return db.SortaProizvoda.Count(e => e.SortaID == id) > 0;
        }
    }
}