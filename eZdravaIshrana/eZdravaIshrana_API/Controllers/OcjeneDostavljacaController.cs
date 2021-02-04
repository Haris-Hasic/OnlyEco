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
    public class OcjeneDostavljacaController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/OcjeneDostavljaca
        public IQueryable<OcjeneDostavljaca> GetOcjeneDostavljaca()
        {
            return db.OcjeneDostavljaca;
        }

        // GET: api/OcjeneDostavljaca/5
        [ResponseType(typeof(OcjeneDostavljaca))]
        public IHttpActionResult GetOcjeneDostavljaca(int id)
        {
            OcjeneDostavljaca ocjeneDostavljaca = db.OcjeneDostavljaca.Find(id);
            if (ocjeneDostavljaca == null)
            {
                return NotFound();
            }

            return Ok(ocjeneDostavljaca);
        }

        // PUT: api/OcjeneDostavljaca/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjeneDostavljaca(int id, OcjeneDostavljaca ocjeneDostavljaca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjeneDostavljaca.OcjenaDostavljacID)
            {
                return BadRequest();
            }

            db.Entry(ocjeneDostavljaca).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjeneDostavljacaExists(id))
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

        // POST: api/OcjeneDostavljaca
        [ResponseType(typeof(OcjeneDostavljaca))]
        public IHttpActionResult PostOcjeneDostavljaca(OcjeneDostavljaca ocjeneDostavljaca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OcjeneDostavljaca.Add(ocjeneDostavljaca);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjeneDostavljaca.OcjenaDostavljacID }, ocjeneDostavljaca);
        }

        // DELETE: api/OcjeneDostavljaca/5
        [ResponseType(typeof(OcjeneDostavljaca))]
        public IHttpActionResult DeleteOcjeneDostavljaca(int id)
        {
            OcjeneDostavljaca ocjeneDostavljaca = db.OcjeneDostavljaca.Find(id);
            if (ocjeneDostavljaca == null)
            {
                return NotFound();
            }

            db.OcjeneDostavljaca.Remove(ocjeneDostavljaca);
            db.SaveChanges();

            return Ok(ocjeneDostavljaca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjeneDostavljacaExists(int id)
        {
            return db.OcjeneDostavljaca.Count(e => e.OcjenaDostavljacID == id) > 0;
        }
    }
}