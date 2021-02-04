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
    public class NarudzbaStavkeController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/NarudzbaStavke
        public IQueryable<NarudzbaStavke> GetNarudzbaStavke()
        {
            return db.NarudzbaStavke;
        }

        // GET: api/NarudzbaStavke/5
        [ResponseType(typeof(NarudzbaStavke))]
        public IHttpActionResult GetNarudzbaStavke(int id)
        {
            NarudzbaStavke narudzbaStavke = db.NarudzbaStavke.Find(id);
            if (narudzbaStavke == null)
            {
                return NotFound();
            }

            return Ok(narudzbaStavke);
        }

        [HttpGet]
        [Route("api/NarudzbaStavke/GetNarudzbeStavkeCustom/{kupacID}/{narudzbaID}")]
        public List<esp_NarudzbaStavkaCustom_ByKupacID_Result> GetNarudzbeStavkeCustom(int kupacID,int narudzbaID)
        {
            //nebas
            return db.esp_NarudzbaStavkaCustom_ByKupacID(kupacID, narudzbaID).ToList();
        }

        [HttpGet]
        [Route("api/NarudzbaStavke/Getprobajsada/{narudzbaID}")]
        public List<NarudzbaStavke> Getprobajsada(int narudzbaID)
        {
            //nebas
            return db.NarudzbaStavke.Where(x=>x.NarudzbaID==narudzbaID).ToList();
        }

        // PUT: api/NarudzbaStavke/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzbaStavke(int id, NarudzbaStavke narudzbaStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbaStavke.NarudzbaStavkaID)
            {
                return BadRequest();
            }

            db.Entry(narudzbaStavke).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbaStavkeExists(id))
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

        // POST: api/NarudzbaStavke
        [ResponseType(typeof(NarudzbaStavke))]
        public IHttpActionResult PostNarudzbaStavke(NarudzbaStavke narudzbaStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NarudzbaStavke.Add(narudzbaStavke);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = narudzbaStavke.NarudzbaStavkaID }, narudzbaStavke);
        }

        // DELETE: api/NarudzbaStavke/5
        [ResponseType(typeof(NarudzbaStavke))]
        public IHttpActionResult DeleteNarudzbaStavke(int id)
        {
            NarudzbaStavke narudzbaStavke = db.NarudzbaStavke.Find(id);
            if (narudzbaStavke == null)
            {
                return NotFound();
            }

            db.NarudzbaStavke.Remove(narudzbaStavke);
            db.SaveChanges();

            return Ok(narudzbaStavke);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbaStavkeExists(int id)
        {
            return db.NarudzbaStavke.Count(e => e.NarudzbaStavkaID == id) > 0;
        }
    }
}