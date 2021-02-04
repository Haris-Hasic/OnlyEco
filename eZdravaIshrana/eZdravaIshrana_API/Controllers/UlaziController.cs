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
    public class UlaziController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Ulazi
        public IQueryable<Ulazi> GetUlazi()
        {
            return db.Ulazi;
        }

        // GET: api/Ulazi/5
        [ResponseType(typeof(Ulazi))]
        public IHttpActionResult GetUlazi(int id)
        {
            Ulazi ulazi = db.Ulazi.Find(id);
            if (ulazi == null)
            {
                return NotFound();
            }

            return Ok(ulazi);
        }
        [HttpGet]
        [Route("api/Ulazi/UlaziDobaljaca/{ID}")]
        public List<esp_Ulazi_Dobavljaca_Result> UlaziDobaljaca(int id)
        {
            return db.esp_Ulazi_Dobavljaca(id).ToList();
        }
        [HttpGet]
        [Route("api/Ulazi/Ulazipretraga/{id?}/{Datumod?}/{Datumdo?}")]
        public List<esp_Ulazi_Pretraga_Result> Ulazipretraga(int id = 0, string Datumod = "", string Datumdo = "")
        {
            DateTime hlp1;
            DateTime hlp2;
            if (Datumod != ""&& Datumdo != "")
            {
                hlp1 = DateTime.ParseExact(Datumod, "yyyy-MM-dd", null);        
                hlp2 = DateTime.ParseExact(Datumdo, "yyyy-MM-dd", null);
                
                return db.esp_Ulazi_Pretraga(hlp1, hlp2, id).ToList();
            }
                return db.esp_Ulazi_Pretraga(null, null, id).ToList();            
        }

        // PUT: api/Ulazi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUlazi(int id, Ulazi ulazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ulazi.UlazID)
            {
                return BadRequest();
            }

            db.Entry(ulazi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlaziExists(id))
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

        // POST: api/Ulazi
        [ResponseType(typeof(Ulazi))]
        public IHttpActionResult PostUlazi(Ulazi ulazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ulazi.Add(ulazi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ulazi.UlazID }, ulazi);
        }

        // DELETE: api/Ulazi/5
        [ResponseType(typeof(Ulazi))]
        public IHttpActionResult DeleteUlazi(int id)
        {
            Ulazi ulazi = db.Ulazi.Find(id);
            if (ulazi == null)
            {
                return NotFound();
            }
            db.esp_Delete_UlazbyID(id);
            db.Ulazi.Remove(ulazi);
            db.SaveChanges();

            return Ok(ulazi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlaziExists(int id)
        {
            return db.Ulazi.Count(e => e.UlazID == id) > 0;
        }
    }
}