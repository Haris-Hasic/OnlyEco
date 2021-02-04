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
    public class KorisniciUlogeController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/KorisniciUloge
        public IQueryable<KorisniciUloge> GetKorisniciUloge()
        {
            return db.KorisniciUloge;
        }

        // GET: api/KorisniciUloge/5
        [ResponseType(typeof(KorisniciUloge))]
        public List<KorisniciUloge> GetKorisniciUloge(int id)
        {
              return db.esp_KorisniciUloge_SelectByID(id).ToList();

        }

        // PUT: api/KorisniciUloge/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisniciUloge(int id, KorisniciUloge korisniciUloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisniciUloge.KorisnikUlogaID)
            {
                return BadRequest();
            }

            db.Entry(korisniciUloge).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciUlogeExists(id))
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

        // POST: api/KorisniciUloge
        [ResponseType(typeof(KorisniciUloge))]
        public IHttpActionResult PostKorisniciUloge(KorisniciUloge korisniciUloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KorisniciUloge.Add(korisniciUloge);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = korisniciUloge.KorisnikUlogaID }, korisniciUloge);
        }

        // DELETE: api/KorisniciUloge/5
        [ResponseType(typeof(KorisniciUloge))]
        public IHttpActionResult DeleteKorisniciUloge(int id)
        {
            KorisniciUloge korisniciUloge = db.KorisniciUloge.Find(id);
            if (korisniciUloge == null)
            {
                return NotFound();
            }

            db.KorisniciUloge.Remove(korisniciUloge);
            db.SaveChanges();

            return Ok(korisniciUloge);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisniciUlogeExists(int id)
        {
            return db.KorisniciUloge.Count(e => e.KorisnikUlogaID == id) > 0;
        }
    }
}