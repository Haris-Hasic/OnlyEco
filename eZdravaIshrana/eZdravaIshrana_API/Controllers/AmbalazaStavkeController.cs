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
using eZdravaIshrana_API.Models;

namespace eZdravaIshrana_API.Controllers
{
    public class AmbalazaStavkeController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/AmbalazaStavke
        public IQueryable<AmbalazaStavke> GetAmbalazaStavke()
        {
            return db.AmbalazaStavke;
        }

        // GET: api/AmbalazaStavke/5
        [ResponseType(typeof(AmbalazaStavke))]
        public IHttpActionResult GetAmbalazaStavke(int id)
        {
            AmbalazaStavke ambalaza = db.AmbalazaStavke.Find(id);
            if (ambalaza == null)
            {
                return NotFound();
            }

            return Ok(ambalaza);
        }
        [HttpGet]
        [Route("api/AmbalazaStavke/GetAmbalaza/{IzlazID}")]
        public List<esp_AmbalazaStavkeGet_Result> GetAmbalaza(int IzlazID)
        {
            return db.esp_AmbalazaStavkeGet(IzlazID).ToList();
        }

        // PUT: api/AmbalazaStavke/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAmbalazaStavke(int id, AmbalazaStavke ambalazaStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ambalazaStavke.AmbalazaStavkaID)
            {
                return BadRequest();
            }

            db.Entry(ambalazaStavke).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmbalazaStavkeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AmbalazaStavke
        [ResponseType(typeof(AmbalazaStavke))]
        public IHttpActionResult PostAmbalazaStavke(AmbalazaStavke ambalazaStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AmbalazaStavke.Add(ambalazaStavke);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ambalazaStavke.AmbalazaStavkaID }, ambalazaStavke);
        }

        // DELETE: api/AmbalazaStavke/5
        [ResponseType(typeof(AmbalazaStavke))]
        public IHttpActionResult DeleteAmbalazaStavke(int id)
        {
            AmbalazaStavke ambalazaStavke = db.AmbalazaStavke.Find(id);
            if (ambalazaStavke == null)
            {
                return NotFound();
            }

            db.AmbalazaStavke.Remove(ambalazaStavke);
            db.SaveChanges();

            return Ok(ambalazaStavke);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AmbalazaStavkeExists(int id)
        {
            return db.AmbalazaStavke.Count(e => e.AmbalazaStavkaID == id) > 0;
        }
    }
}