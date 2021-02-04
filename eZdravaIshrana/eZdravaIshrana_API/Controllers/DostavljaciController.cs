using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eZdravaIshrana_API.Models;

namespace eZdravaIshrana_API.Controllers
{
    public class DostavljaciController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Dostavljaci  GetDostavljacBystr
        public IQueryable<Dostavljaci> GetDostavljaci()
        {
            return db.Dostavljaci;
        }


        [HttpGet]
        [Route("api/Dostavljaci/GetDostavljacBystr/{naziv?}")]
        public List<esp_Dostavljac_Pretraga_Result> GetDostavljacBystr(string naziv = "")
        {
            return db.esp_Dostavljac_Pretraga(naziv).ToList();
        }

        [HttpGet]
        [Route("api/Dostavljaci/GetDostavljaciByUsername/{username?}")]
        public IHttpActionResult GetDostavljaciByUsername(string username = "")
        {
            Dostavljaci k = db.Dostavljaci.Where(x => x.KorisnickoIme == username && x.Status == true).FirstOrDefault();
            if (k == null)
                return NotFound();
            return Ok(k);
        }

        [HttpGet]
        [Route("api/Dostavljaci/GetCheckEmail/{email}")]
        public Kupci GetCheckEmail(string email = "")
        {
            email=email.Replace(',','.');
            return db.esp_Dostavljaci_CheckKupciEmail(email).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Dostavljaci/CheckAcc/{acc}")]
        public Kupci CheckAcc(string acc)
        {
            acc = acc.Replace(',', '.');
            return db.esp_Dostavljaci_CheckKupciKorisnickoIme(acc).FirstOrDefault();
        }
        // GET: api/Dostavljaci/5
        [ResponseType(typeof(Dostavljaci))]
        public IHttpActionResult GetDostavljaci(int id)
        {
            Dostavljaci dostavljaci = db.Dostavljaci.Find(id);
            if (dostavljaci == null)
            {
                return NotFound();
            }

            return Ok(dostavljaci);
        }

        // PUT: api/Dostavljaci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDostavljaci(int id, Dostavljaci dostavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dostavljaci.DostavljacID)
            {
                return BadRequest();
            }

            db.Entry(dostavljaci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DostavljaciExists(id))
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

        // POST: api/Dostavljaci
        [ResponseType(typeof(Dostavljaci))]
        public IHttpActionResult PostDostavljaci(Dostavljaci dostavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           
            try
            {
                db.esp_Dostavljaci_Insert(dostavljaci.Naziv, dostavljaci.KontaktOsoba, dostavljaci.Adresa, dostavljaci.Telefon,
                    dostavljaci.Fax, dostavljaci.Web, dostavljaci.Email, dostavljaci.ZiroRacuni, dostavljaci.Napomena,
                    dostavljaci.KorisnickoIme, dostavljaci.LozinkaSalt, dostavljaci.LozinkaHash);
                //NAPRAVITI PROCEDURU 

            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }

            db.SaveChanges();



            return CreatedAtRoute("DefaultApi", new { id = dostavljaci.DostavljacID }, dostavljaci);
        }

        private Exception CreateHttpResponseException(string reason, HttpStatusCode status)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = status,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }

        // DELETE: api/Dostavljaci/5
        [ResponseType(typeof(Dostavljaci))]
        public IHttpActionResult DeleteDostavljaci(int id)
        {
            Dostavljaci dostavljaci = db.Dostavljaci.Find(id);
            if (dostavljaci == null)
            {
                return NotFound();
            }

            db.Dostavljaci.Remove(dostavljaci);
            db.SaveChanges();

            return Ok(dostavljaci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DostavljaciExists(int id)
        {
            return db.Dostavljaci.Count(e => e.DostavljacID == id) > 0;
        }
    }
}