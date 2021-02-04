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
    public class DobavljaciController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Dobavljaci
        public IQueryable<Dobavljaci> GetDobavljaci()
        {
            return db.Dobavljaci;
        }
        [HttpGet]
        [Route("api/Dobavljaci/PretragaDobavljaci/{id?}/{naziv?}")]
        public List<esp_Dobavljaci_Pretraga_Result> PretragaDobavljaci(int id=0,string naziv="")
        {
            return db.esp_Dobavljaci_Pretraga(naziv,id).ToList();
        }

        // GET: api/Dobavljaci/5
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult GetDobavljaci(int id)
        {
            Dobavljaci dobavljaci = db.Dobavljaci.Find(id);
            if (dobavljaci == null)
            {
                return NotFound();
            }

            return Ok(dobavljaci);
        }

        // PUT: api/Dobavljaci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDobavljaci(int id, Dobavljaci dobavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dobavljaci.DobavljacID)
            {
                return BadRequest();
            }

            db.Entry(dobavljaci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DobavljaciExists(id))
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

        // POST: api/Dobavljaci
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult PostDobavljaci(Dobavljaci dobavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dobavljaci.Add(dobavljaci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dobavljaci.DobavljacID }, dobavljaci);
        }

        // DELETE: api/Dobavljaci/5
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult DeleteDobavljaci(int id)
        {
            Dobavljaci dobavljaci = db.Dobavljaci.Find(id);
            if (dobavljaci == null)
            {
                return NotFound();
            }

            db.Dobavljaci.Remove(dobavljaci);
            db.SaveChanges();

            return Ok(dobavljaci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DobavljaciExists(int id)
        {
            return db.Dobavljaci.Count(e => e.DobavljacID == id) > 0;
        }
    }
}