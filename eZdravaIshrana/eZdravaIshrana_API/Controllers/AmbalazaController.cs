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
    public class AmbalazaController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Ambalaza
        public IQueryable<Ambalaza> GetAmbalaza()
        {
            return db.Ambalaza;
        }

        // GET: api/Ambalaza/5
        [ResponseType(typeof(Ambalaza))]
        public IHttpActionResult GetAmbalaza(int id)
        {
            Ambalaza ambalaza = db.Ambalaza.Find(id);
            if (ambalaza == null)
            {
                return NotFound();
            }

            return Ok(ambalaza);
        }

        // PUT: api/Ambalaza/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAmbalaza(int id, Ambalaza ambalaza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ambalaza.AmbalazaID)
            {
                return BadRequest();
            }

            db.Entry(ambalaza).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmbalazaExists(id))
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

        // POST: api/Ambalaza
        [ResponseType(typeof(Ambalaza))]
        public IHttpActionResult PostAmbalaza(Ambalaza ambalaza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ambalaza.Add(ambalaza);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ambalaza.AmbalazaID }, ambalaza);
        }

        // DELETE: api/Ambalaza/5
        [ResponseType(typeof(Ambalaza))]
        public IHttpActionResult DeleteAmbalaza(int id)
        {
            Ambalaza ambalaza = db.Ambalaza.Find(id);
            if (ambalaza == null)
            {
                return NotFound();
            }

            db.Ambalaza.Remove(ambalaza);
            db.SaveChanges();

            return Ok(ambalaza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AmbalazaExists(int id)
        {
            return db.Ambalaza.Count(e => e.AmbalazaID == id) > 0;
        }
    }
}