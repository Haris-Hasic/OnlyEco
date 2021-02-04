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
using System.Data.Entity.Core;

namespace eZdravaIshrana_API.Controllers
{
    public class KupciController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Kupci
        public IQueryable<Kupci> GetKupci()
        {
            return db.Kupci;
        }
        //check
        [HttpGet]
        [Route("api/Kupci/CheckEmail/{email}")]
        public IHttpActionResult CheckEmail(string email)
        {
            //?
            string k = db.esp_Kupci_Check_Email(email).FirstOrDefault();
            if (k == null)
                return NotFound();
            return Ok(k);
        }
        [Route("api/Kupci/GetKupciByUsername/{username?}")]
        public IHttpActionResult GetKupciByUsername(string username = "")
        {
            Kupci k = db.Kupci.Where(x => x.KorisnickoIme == username && x.Status == true).FirstOrDefault();
            if (k == null)
                return NotFound();
            return Ok(k);
        }
        // GET: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult GetKupci(int id)
        {
            Kupci kupci = db.Kupci.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            return Ok(kupci);
        }
        [HttpGet]
        [Route("api/Kupci/CheckEmail2/{email}")]
        public Dostavljaci CheckEmail2(string email)
        {
            email = email.Replace(',', '.');
            return db.esp_Kupci_CheckDostavljaciEmail(email).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Kupci/CheckAcc/{acc}")]
        public Dostavljaci CheckAcc(string acc)
        {
            acc = acc.Replace(',', '.');
            return db.esp_Kupci_CheckDostavljaciKorisnickoIme(acc).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Kupci/GetByName/{name?}")]
        public List<Kupci> GetByName(string name = "")
        {

            return db.esp_Kupci_SelectByImePrezime(name).ToList();

        }

        // PUT: api/Kupci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKupci(int id, Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kupci.KupacID)
            {
                return BadRequest();
            }

            db.Entry(kupci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KupciExists(id))
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
      

        // POST: api/Kupci
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult PostKupci(Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                kupci.KupacID = Convert.ToInt32(db.esp_Kupci_Insert(kupci.Ime, kupci.Prezime, kupci.DatumRegistracije, kupci.Email,
                                                                  kupci.KorisnickoIme, kupci.LozinkaHash, kupci.LozinkaSalt, kupci.Status).SingleOrDefault());
            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
         

            return CreatedAtRoute("DefaultApi", new { id = kupci.KupacID }, kupci);
        }
        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode status)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = status,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }
        // DELETE: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult DeleteKupci(int id)
        {
            Kupci kupci = db.Kupci.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }
        
            db.Kupci.Remove(kupci);
            db.SaveChanges();

            return Ok(kupci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KupciExists(int id)
        {
            return db.Kupci.Count(e => e.KupacID == id) > 0;
        }
    }
}