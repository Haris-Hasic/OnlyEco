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
    public class IzlazStavkeController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/IzlazStavke
        public IQueryable<IzlazStavke> GetIzlazStavke()
        {
            return db.IzlazStavke;
        }

        // GET: api/IzlazStavke/5
        [HttpGet]
        [ResponseType(typeof(IzlazStavke))]
        public List<esp_IzlazStavke_ByIzlazID_Result> GetIzlazStavke(int id)
        {
           
            return db.esp_IzlazStavke_ByIzlazID(id).ToList();
        }

        [HttpGet]
        [ResponseType(typeof(IzlazStavke))]
        [Route("api/IzlazStavke/GetIzlaziStavkehlp/{id}")]
        public IHttpActionResult GetIzlaziStavkehlp(int id)
        {
            IzlazStavke izlazistavke = db.IzlazStavke.Find(id);
            if (izlazistavke == null)
            {
                return NotFound();
            }

            return Ok(izlazistavke);
        }
        [HttpGet]
        [Route("api/IzlazStavke/GetIzlazStavkeCustom/{izlazID}")]
        public List<esp_IzlaziStavke_GetByIzlazID_Result> GetIzlazStavkeCustom(int izlazID)
        {
            return db.esp_IzlaziStavke_GetByIzlazID(izlazID).ToList();
        }

        // PUT: api/IzlazStavke/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIzlazStavke(int id, IzlazStavke izlazStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != izlazStavke.IzlazStavkaID)
            {
                return BadRequest();
            }

            db.Entry(izlazStavke).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzlazStavkeExists(id))
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

        // POST: api/IzlazStavke
        [ResponseType(typeof(IzlazStavke))]
        public IHttpActionResult PostIzlazStavke(IzlazStavke izlazStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.IzlazStavke.Add(izlazStavke);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = izlazStavke.IzlazStavkaID }, izlazStavke);
        }

        // DELETE: api/IzlazStavke/5
        [ResponseType(typeof(IzlazStavke))]
        public IHttpActionResult DeleteIzlazStavke(int id)
        {
            IzlazStavke izlazStavke = db.IzlazStavke.Find(id);
            if (izlazStavke == null)
            {
                return NotFound();
            }

            db.IzlazStavke.Remove(izlazStavke);
            db.SaveChanges();

            return Ok(izlazStavke);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IzlazStavkeExists(int id)
        {
            return db.IzlazStavke.Count(e => e.IzlazStavkaID == id) > 0;
        }
    }
}