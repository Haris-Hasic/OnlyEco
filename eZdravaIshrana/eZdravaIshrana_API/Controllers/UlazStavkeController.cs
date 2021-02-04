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
    public class UlazStavkeController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/UlazStavke
        public IQueryable<UlazStavke> GetUlazStavke()
        {
            return db.UlazStavke;
        }
        [ResponseType(typeof(UlazStavke))]
        public IHttpActionResult GetUlazStavke(int id)
        {
            UlazStavke ulazStavke = db.UlazStavke.Find(id);
            if (ulazStavke == null)
            {
                return NotFound();
            }

            return Ok(ulazStavke);
        }
   
        // GET: api/UlazStavke/5
        [HttpGet]
        [Route("api/UlazStavke/UlazStavkeByUlazID/{ID}")]
        public List<esp_UlaziStavke_byUlazID_Result> UlazStavkeByUlazID(int id)
        {

            return db.esp_UlaziStavke_byUlazID(id).ToList();
        }

        [HttpGet]
        [Route("api/UlazStavke/Provjera/{proizvodID}/{ulazID}")]
        public UlazStavke Provjera(int proizvodID,int ulazID)
        {

            return db.esp_CheckNabavkaStavke_ByProizvodID(ulazID, proizvodID).FirstOrDefault();
        }
        [HttpGet]
        [Route("api/UlazStavke/UlazStavkeByUlazID2/{ID}")]
        public List<esp_UlazStavkeByUlazID_Prikazi_Result> UlazStavkeByUlazID2(int id)
        {

            return db.esp_UlazStavkeByUlazID_Prikazi(id).ToList();
        }

        [HttpPost]
        [Route("api/UlazStavke/PostUlazStavkeHlp/{ID}")]
        public IHttpActionResult PostUlazStavkeHlp(int id, UlazStavke ulazStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ulazStavke.UlazStavkaID)
            {
                return BadRequest();
            }

            db.Entry(ulazStavke).State = EntityState.Modified;



            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlazStavkeExists(id))
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
        // PUT: api/UlazStavke/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUlazStavke(int id, UlazStavke ulazStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ulazStavke.UlazStavkaID)
            {
                return BadRequest();
            }
            
            

          
            db.Entry(ulazStavke).State = EntityState.Modified;


            Ulazi ulazi = db.Ulazi.Find(ulazStavke.UlazID);
            List<UlazStavke> listaulazaStavke = db.UlazStavke.Where(x => x.UlazID == ulazi.UlazID).ToList();
            decimal suma = 0;
            decimal pdv = 0;
            foreach (UlazStavke x in listaulazaStavke)
            {
                suma = suma + (x.Kolicina * x.Cijena);
            }
            pdv = (suma * ulazi.PDV);
            pdv = Math.Round(pdv, 2);
            suma = suma + pdv;
            ulazi.IznosRacuna = suma;

            db.Entry(ulazi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlazStavkeExists(id))
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

        // POST: api/UlazStavke
        [ResponseType(typeof(UlazStavke))]
        public IHttpActionResult PostUlazStavke(UlazStavke ulazStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UlazStavke.Add(ulazStavke);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ulazStavke.UlazStavkaID }, ulazStavke);
        }

        // DELETE: api/UlazStavke/5
        [ResponseType(typeof(UlazStavke))]
        public IHttpActionResult DeleteUlazStavke(int id)
        {
            UlazStavke ulazStavke = db.UlazStavke.Find(id);
            if (ulazStavke == null)
            {
                return NotFound();
            }

            db.UlazStavke.Remove(ulazStavke);
            db.SaveChanges();

            return Ok(ulazStavke);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlazStavkeExists(int id)
        {
            return db.UlazStavke.Count(e => e.UlazStavkaID == id) > 0;
        }
    }
}