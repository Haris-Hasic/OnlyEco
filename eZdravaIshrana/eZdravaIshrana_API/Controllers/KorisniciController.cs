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
    public class KorisniciController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Korisnici
        public IQueryable<Korisnici> GetKorisnici()
        {
            return db.Korisnici;
        }
        [HttpGet]
        [Route("api/Korisnici/SearchKorisnici/{name?}")]
        public List<Korisnici> SearchKorisnici(string name="")
        {
            return db.esp_Korisnici_SelectByImePrezime(name).ToList();
        }

      

        [HttpGet]       
        [Route("api/Korisnici/GetKorisniciByID/{id}")]
        public IHttpActionResult GetKorisniciByID(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }
         

            return Ok(korisnici);
        }
        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/{username}")]
        [HttpGet]
        public IHttpActionResult GetKorisnici(string username)
        {
            Korisnici korisnik = db.Korisnici.Where(x=>x.KorisnickoIme==username).FirstOrDefault();
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }

        // PUT: api/Korisnici/5

         [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
        
            if (id != korisnici.KorisnikID)
            {
                return BadRequest();
            }
            List<KorisniciUloge> korisniciUloge = db.KorisniciUloge.Where(x => x.KorisnikID == id).ToList();
            int brojac = 0;
            for (int i = 0; i < korisniciUloge.Count; i++)
            {
                brojac = 0;
                for (int j = 0; j < korisnici.Uloge.Count; j++)
                {
                    if (korisniciUloge[i].UlogaID == korisnici.Uloge[j].UlogaID)
                        brojac++;
                }
                if (brojac == 0)
                {
                    db.esp_KorisniciUloge_DeleteByID(id, korisniciUloge[i].UlogaID);
                }
            }

            int brojac1 = 0;
            for (int i = 0; i < korisnici.Uloge.Count; i++)
            {
                brojac1 = 0;
                for (int j = 0; j < korisniciUloge.Count; j++)
                {
                    if (korisniciUloge[j].UlogaID == korisnici.Uloge[i].UlogaID)
                        brojac1++;
                }
                if (brojac1 == 0)
                {
                    db.esp_KorisniciUloge_Insert(id, korisnici.Uloge[i].UlogaID);
                }
            }

            db.Entry(korisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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

        // PUT: api/Skladista/5
        [HttpPut]
        [Route("api/Korisnici/PutcustomKorisnicistatus/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutcustomKorisnicistatus(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnici.KorisnikID)
            {
                return BadRequest();
            }

            db.Entry(korisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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
        [HttpPut]
        [Route("api/Korisnici/PutCustomKorisnici/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCustomKorisnici(int id, Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnici.KorisnikID)
            {
                return BadRequest();
            }
            List<KorisniciUloge> korisniciUloge = db.KorisniciUloge.Where(x => x.KorisnikID == id).ToList();
            int brojac = 0;
            for (int i = 0; i < korisniciUloge.Count; i++)
            {
                brojac = 0;
                for (int j = 0; j < korisnici.Uloge.Count; j++)
                {
                    if (korisniciUloge[i].UlogaID == korisnici.Uloge[j].UlogaID)
                        brojac++;
                }
                if (brojac == 0)
                {
                    db.esp_KorisniciUloge_DeleteByID(id, korisniciUloge[i].UlogaID);
                }
            }

            int brojac1 = 0;
            for (int i = 0; i < korisnici.Uloge.Count; i++)
            {
                brojac1 = 0;
                for (int j = 0; j < korisniciUloge.Count; j++)
                {
                    if (korisniciUloge[j].UlogaID == korisnici.Uloge[i].UlogaID)
                        brojac1++;
                }
                if (brojac1 == 0)
                {
                    db.esp_KorisniciUloge_Insert(id, korisnici.Uloge[i].UlogaID);
                }
            }

            db.Entry(korisnici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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

        // POST: api/Korisnici
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult PostKorisnici(Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Korisnici.Add(korisnici);
            //db.SaveChanges();
            try
            {
                korisnici.KorisnikID = Convert.ToInt32(db.esp_Korisnici_Insert(korisnici.Ime, korisnici.Prezime, korisnici.Email, korisnici.Telefon,
                                           korisnici.KorisnickoIme, korisnici.LozinkaSalt, korisnici.LozinkaHash).FirstOrDefault());

            }
            catch (EntityException ex)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            foreach (Uloge x in korisnici.Uloge)
            {
                db.esp_KorisniciUloge_Insert(korisnici.KorisnikID, x.UlogaID);
            }
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = korisnici.KorisnikID }, korisnici);
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode status)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                StatusCode = status,
                ReasonPhrase = reason,
                Content= new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }

        // DELETE: api/Korisnici/5 DeleteCustomResponse
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult DeleteKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

           

            db.Korisnici.Remove(korisnici);
            db.SaveChanges();

            return Ok(korisnici);
        }

      
        [HttpDelete]
        [Route("api/Korisnici/DeleteCustom/{id}")]
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult DeleteCustom(int id)
        {
            Korisnici korisnici = db.Korisnici.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }



            korisnici.Status = false;
            db.SaveChanges();

            return Ok(korisnici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisniciExists(int id)
        {
            return db.Korisnici.Count(e => e.KorisnikID == id) > 0;
        }
    }
}