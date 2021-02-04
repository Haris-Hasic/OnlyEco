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
    public class IzlaziController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Izlazi
        public IQueryable<Izlazi> GetIzlazi()
        {
            return db.Izlazi;
        }

        [HttpGet]
        [Route("api/Izlazi/IzlazByID/{id}")]
        public IHttpActionResult IzlazByID(int id)
        {
            Izlazi iz = db.Izlazi.Find(id);
            if (iz == null)
            {
                return NotFound();
            }


            return Ok(iz);
        }
        [HttpGet]
        [Route("api/Izlazi/Izlazipretraga/{Datumod?}/{Datumdo?}/{brojracuna?}")]
        public List<esp_Izlaz_Pretraga_Result> Izlazipretraga(string Datumod = "", string Datumdo = "",string brojracuna = "")
        {
            DateTime hlp1;
            DateTime hlp2;
            if (Datumod != "" && Datumdo != "")
            {
                hlp1 = DateTime.ParseExact(Datumod, "yyyy-MM-dd", null);
                hlp2 = DateTime.ParseExact(Datumdo, "yyyy-MM-dd", null);

                return db.esp_Izlaz_Pretraga(brojracuna,hlp1, hlp2).ToList();
            }
            return db.esp_Izlaz_Pretraga(brojracuna, null, null).ToList();
        }

        [HttpGet]
        [Route("api/Izlazi/IzlaziDostavljac/{DostavljacID}")]
        public List<esp_Izlaz_Get_DobavljacID_Result> IzlaziDostavljac(int DostavljacID)
        { 
            return db.esp_Izlaz_Get_DobavljacID(DostavljacID).ToList();
        }

        [HttpGet]
        [Route("api/Izlazi/IzlaziOcjeni/{KupacID}")]
        public List<esp_izlaz_getByKupacOcjeni_Result> IzlaziOcjeni(int KupacID)
        {
            return db.esp_izlaz_getByKupacOcjeni(KupacID).ToList();
        }


        [HttpGet]
        [Route("api/Izlazi/IzlaziDostavljaczakljucene/{DostavljacID}")]
        public List<esp_Izlaz_GetZakljucene_DobavljacID_Result> IzlaziDostavljaczakljucene(int DostavljacID)
        {
            return db.esp_Izlaz_GetZakljucene_DobavljacID(DostavljacID).ToList();
        }
        // GET: api/Izlazi/5
        [ResponseType(typeof(Izlazi))]
        public IHttpActionResult GetIzlazi(int id)
        {
            Izlazi izlazi = db.Izlazi.Find(id);
            if (izlazi == null)
            {
                return NotFound();
            }

            return Ok(izlazi);
        }
        // PUT: api/Izlazi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIzlazi(int id, Izlazi izlazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != izlazi.IzlazID)
            {
                return BadRequest();
            }

            db.Entry(izlazi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzlaziExists(id))
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

        // POST: api/Izlazi
        [ResponseType(typeof(Izlazi))]
        public IHttpActionResult PostIzlazi(Izlazi izlazi)
        {
            List<NarudzbaStavke> hlp = db.NarudzbaStavke.Where(x => x.NarudzbaID == izlazi.NarudzbaID).ToList();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            int IzlazID = Convert.ToInt32(db.esp_Izlazi_Insert(izlazi.BrojRacuna, izlazi.Datum, izlazi.KorisnikID, izlazi.Zakljucen, izlazi.IznosBezPDV, izlazi.IznosSaPDV, izlazi.NarudzbaID,
                                                izlazi.SkladisteID, izlazi.DostavljacID, izlazi.UdaljenostRute, izlazi.VrijemeRute, izlazi.Latitude, izlazi.Longitude, izlazi.PayByCard, izlazi.KupacID).FirstOrDefault()); 
            foreach (var x in hlp)
            {
                IzlazStavke h = new IzlazStavke();
                h.Cijena = x.CijenaProizvoda;
                h.IzlazID = IzlazID;
                h.Kolicina = x.Kolicina;
                h.Popust = 0;
                h.ProizvodID = x.ProizvodID;
                h.Ocjenjeno = false;
                db.IzlazStavke.Add(h);
                    
             }
            //db.Izlazi.Add(izlazi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = izlazi.IzlazID }, izlazi);
        }

        // DELETE: api/Izlazi/5
        [ResponseType(typeof(Izlazi))]
        public IHttpActionResult DeleteIzlazi(int id)
        {
            Izlazi izlazi = db.Izlazi.Find(id);
            if (izlazi == null)
            {
                return NotFound();
            }

            db.Izlazi.Remove(izlazi);
            db.SaveChanges();

            return Ok(izlazi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IzlaziExists(int id)
        {
            return db.Izlazi.Count(e => e.IzlazID == id) > 0;
        }
    }
}