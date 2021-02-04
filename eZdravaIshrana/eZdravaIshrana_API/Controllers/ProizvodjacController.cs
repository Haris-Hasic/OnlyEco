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
    public class ProizvodjacController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        public IQueryable<Proizvodjac> GetProizvodjac()
        {
            return db.Proizvodjac;
        }
        // GET: api/Proizvodjac
        [HttpGet]
        [Route("api/Proizvodjac/GetProizvodjacBystr/{imePrezime?}")]
        public List<Proizvodjac> GetProizvodjacBystr(string imePrezime="")
        {
            return db.esp_Proizvodjac_Pretraga2(imePrezime).ToList();
        }

        // GET: api/Proizvodjac/5
        [ResponseType(typeof(Proizvodjac))]
        public IHttpActionResult GetProizvodjac(int id)
        {
            Proizvodjac proizvodjac = db.Proizvodjac.Find(id);
            if (proizvodjac == null)
            {
                return NotFound();
            }

            return Ok(proizvodjac);
        }
        //ImePrezime
        [HttpGet]
        [Route("api/Proizvodjac/PretragaProizvodjaca/{SortaID?}/{ImePrezime?}/{ProizvodNaziv?}")]

        public List<esp_Proizvodjac_Pretraga_Result> PretragaProizvodjaca(int SortaID=0,string ImePrezime="",string ProizvodNaziv="")
        {
            if (ImePrezime == "Cant solve")
                ImePrezime = "";
            return db.esp_Proizvodjac_Pretraga(ImePrezime, ProizvodNaziv, SortaID).ToList();
        }
        // PUT: api/Proizvodjac/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProizvodjac(int id, Proizvodjac proizvodjac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proizvodjac.ProizvodjacID)
            {
                return BadRequest();
            }

            db.Entry(proizvodjac).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProizvodjacExists(id))
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

        // POST: api/Proizvodjac
        [ResponseType(typeof(Proizvodjac))]
        public IHttpActionResult PostProizvodjac(Proizvodjac proizvodjac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Proizvodjac.Add(proizvodjac);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = proizvodjac.ProizvodjacID }, proizvodjac);
        }

        // DELETE: api/Proizvodjac/5
        [ResponseType(typeof(Proizvodjac))]
        public IHttpActionResult DeleteProizvodjac(int id)
        {
            Proizvodjac proizvodjac = db.Proizvodjac.Find(id);
            if (proizvodjac == null)
            {
                return NotFound();
            }

            db.Proizvodjac.Remove(proizvodjac);
            db.SaveChanges();

            return Ok(proizvodjac);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProizvodjacExists(int id)
        {
            return db.Proizvodjac.Count(e => e.ProizvodjacID == id) > 0;
        }
    }
}