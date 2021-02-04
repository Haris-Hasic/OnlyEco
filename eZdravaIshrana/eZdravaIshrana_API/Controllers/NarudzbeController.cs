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
    public class NarudzbeController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Narudzbe
        public IQueryable<Narudzbe> GetNarudzbe()
        {
            return db.Narudzbe;
        }

        // GET: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult GetNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbe.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            return Ok(narudzbe);
        }

        [HttpGet]
        [Route("api/Narudzbe/GetBrojAktivnihNarudzbi")]
        public int GetBrojAktivnihNarudzbi()
        {
            return db.Narudzbe.Where(x => x.Status == true).Count();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetBrojNarudzbi")]
        public int GetBrojNarudzbi()
        {
            int a = db.esp_Narudzbe_GetNumber().First().Value;
            return a;
        }

        [HttpGet]
        [Route("api/Narudzbe/GetNarudzbeCustom/{kupacID}")]
        public List<esp_NarudzbaCustom_ByKupacID_Result> GetNarudzbeCustom(int kupacID)
        {
            return db.esp_NarudzbaCustom_ByKupacID(kupacID).ToList();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetNarudzbeAktive/{kupacID}")]
        public List<esp_Narudzbe_MobileAktiv_Result> GetNarudzbeAktive(int kupacID)
        {
            return db.esp_Narudzbe_MobileAktiv(kupacID).ToList();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetPonisteneCC/{PayByCard?}/{kupac?}/{BrojNarudzbe?}")]
        public List<esp_Narudzbe_PonistiCC_Result> GetPonisteneCC(bool PayByCard = true,string kupac="",string BrojNarudzbe="")
        {
            if (kupac=="Cant solve")
            {
                kupac = "";
            }
            return db.esp_Narudzbe_PonistiCC(kupac, BrojNarudzbe, PayByCard).ToList();
        }
        [HttpGet]
        [Route("api/Narudzbe/GetAktivneNarudzbe")]
        public List<esp_Narudzbe_SelectAktivne_Result> GetAktivneNarudzbe()
        {
            return db.esp_Narudzbe_SelectAktivne().ToList();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetStavkeNarudzbe/{id}")]
        public List<esp_NarudbeStavke_SelectByNarudzbaID_Result> GetStavkeNarudzbe(int id)
        {
            return db.esp_NarudbeStavke_SelectByNarudzbaID(id).ToList();
        }

       


        // PUT: api/Narudzbe/5
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzbe(int id, Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbe.NarudzbaID)
            {
                return BadRequest();
            }
            narudzbe.Status = false;
            //status se mjenja
            db.esp_Narudzbe_Procesirana(id);
            if(narudzbe.Otkazano==true)
            db.esp_Narudzbe_Otkazana(id);

           /// db.Entry(narudzbe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbeExists(id))
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

        // POST: api/Narudzbe
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult PostNarudzbe(Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //++tested
            narudzbe.NarudzbaID = Convert.ToInt32(db.esp_Narudzbe_Insert(narudzbe.BrojNarudzbe, narudzbe.KupacID, narudzbe.Latitude
                , narudzbe.Longitude, narudzbe.SkladisteID, narudzbe.UdaljenostRute, narudzbe.VrijemeRute, narudzbe.IznosBezPDV, narudzbe.IznosSaPDV, narudzbe.PayByCard).FirstOrDefault());

            foreach (NarudzbaStavke x in narudzbe.NarudzbaStavke)
            {
                db.esp_NarudzbaStavke_Insert(narudzbe.NarudzbaID, x.ProizvodID, x.Kolicina, x.Proizvodi.Cijena);
            }
            return CreatedAtRoute("DefaultApi", new { id = narudzbe.NarudzbaID }, narudzbe);
        }

        [HttpPost]
        [Route("api/Narudzbe/ProcesirajNarudzbu")]
        public void ProcesirajNarudzbu(Izlazi izlazi)
        {
            db.esp_Izlazi_InsertByNarudzbaID(izlazi.NarudzbaID, izlazi.IznosSaPDV, izlazi.IznosBezPDV, izlazi.SkladisteID, izlazi.KorisnikID);
        }

        [HttpPost]
        [Route("api/Narudzbe/ProcesirajAktivnuNarudzbu/{id}")]
        public void ProcesirajAktivnuNarudzbu(int id)
        {
            db.esp_Narudzbe_Procesirana(id);
        }

        // DELETE: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult DeleteNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbe.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }
            //vidi da li radi ovo 
           List<NarudzbaStavke> hlp= db.NarudzbaStavke.Where(x => x.NarudzbaID == id).ToList();
            foreach (var x in hlp)
            {
                db.NarudzbaStavke.Remove(x);
            }
            db.Narudzbe.Remove(narudzbe);
            db.SaveChanges();

            return Ok(narudzbe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbeExists(int id)
        {
            return db.Narudzbe.Count(e => e.NarudzbaID == id) > 0;
        }
    }
}