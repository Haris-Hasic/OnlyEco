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
    public class SkladistaController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Skladista
        public IQueryable<Skladista> GetSkladista()
        {
            return db.Skladista;
        }

       

        // GET: api/Skladista/5
        [ResponseType(typeof(Skladista))]
        public IHttpActionResult GetSkladista(int id)
        {
            Skladista skladista = db.Skladista.Find(id);
            if (skladista == null)
            {
                return NotFound();
            }

            return Ok(skladista);
        }
        [HttpGet]
        [Route("api/Skladista/SearchSkladista/{vrstaID?}/{sortaID?}/{adresa?}/{proizvod?}")]
        public List<esp_Skadiste_Pretraga_Result> SearchSkladista(int vrstaID = 0, int sortaID = 0, string adresa = "", string proizvod = "")
        {
            if (adresa == "Cant Solve")
                adresa = "";


            return db.esp_Skadiste_Pretraga(adresa, proizvod, vrstaID, sortaID).ToList();

        }
        [HttpGet]
        [Route("api/Skladista/GetAllUlazi/{skladisteID?}")]
        public List<esp_SkadisteGetUlazi_zastaanje_Result> GetAllUlazi(int skladisteID = 0)
        {
          
            return db.esp_SkadisteGetUlazi_zastaanje(skladisteID).ToList();

        }

        [HttpGet]
        [Route("api/Skladista/GetAllIzlazi/{skladisteID?}")]
        public List<esp_SkadisteGetIzlazi_zastaanje_Result> GetAllIzlazi(int skladisteID = 0)
        {

            return db.esp_SkadisteGetIzlazi_zastaanje(skladisteID).ToList();

        }


        // PUT: api/Skladista/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSkladista(int id, Skladista skladista)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skladista.SkladisteID)
            {
                return BadRequest();
            }

            db.Entry(skladista).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkladistaExists(id))
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

        // POST: api/Skladista
        [ResponseType(typeof(Skladista))]
        public IHttpActionResult PostSkladista(Skladista skladista)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Skladista.Add(skladista);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = skladista.SkladisteID }, skladista);
        }

        // DELETE: api/Skladista/5
        [ResponseType(typeof(Skladista))]
        public IHttpActionResult DeleteSkladista(int id)
        {
            Skladista skladista = db.Skladista.Find(id);
            if (skladista == null)
            {
                return NotFound();
            }

            db.Skladista.Remove(skladista);
            db.SaveChanges();

            return Ok(skladista);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SkladistaExists(int id)
        {
            return db.Skladista.Count(e => e.SkladisteID == id) > 0;
        }
    }
}