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
using eZdravaIshrana_API.Util;

namespace eZdravaIshrana_API.Controllers
{
    public class ProizvodiController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Proizvodi
        public IQueryable<Proizvodi> GetProizvodi()
        {
            return db.Proizvodi;
        }
        [HttpGet]
        [Route("api/Proizvodi/Pretraga")]
        public List<Proizvodi> SearchProizvodi()
        {
          


            return db.Proizvodi.ToList();

        }
        [HttpGet]
        [Route("api/Proizvodi/SearchProizvodi/{proizvodjacID?}/{vrstaProizvodaID?}/{sortaProizvodaID?}/{cijena?}/{naziv?}/{sifra?}")]
        public List<esp_Proizvodi_Pretraga_Result> SearchProizvodi(int proizvodjacID = 0, int vrstaProizvodaID = 0, int sortaProizvodaID = 0, decimal cijena = 0, string naziv = "", string sifra = "")
        {
            if (naziv == "Cant Solve")
                naziv = "";


            return db.esp_Proizvodi_Pretraga(naziv, sifra, cijena, vrstaProizvodaID, sortaProizvodaID, proizvodjacID).ToList();

        }
        [HttpGet]
        [Route("api/Proizvodi/SearchProizvodiMobile/{vrstaProizvodaID?}/{naziv?}")]
        public List<esp_Proizvodi_Pretraga2_Result> SearchProizvodiMobile(int vrstaProizvodaID = 0,string naziv = "")
        {

            return db.esp_Proizvodi_Pretraga2(naziv,vrstaProizvodaID).ToList();

        }
        // GET: api/Proizvodi/5
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult GetProizvodi(int id)
        {
            Proizvodi proizvodi = db.Proizvodi.Find(id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            return Ok(proizvodi);
        }
        [HttpGet]
        [Route("api/Proizvodi/GetProizvodiCustom/{id}")]
        public esp_ProizvodCustom_ByID_Result GetProizvodiCustom(int id)
        {
            return db.esp_ProizvodCustom_ByID(id).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/Proizvodi/GetTop3")]
        public List<esp_GetFreshProizvodi3_Result> GetTop3()
        {
            return db.esp_GetFreshProizvodi3().ToList();
        }

        [HttpGet]
        [Route("api/Proizvodi/RecommendProduct/{productID}")]
        public List<esp_Proizvodi_ByProizvodID_Result> RecommendProduct(int productID)
        {
            Recommender r = new Recommender();

            return r.GetSlicneProizvode(productID);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult PutProizvodi(int id, Proizvodi proizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proizvodi.ProizvodID)
            {
                return BadRequest();
            }

            db.Entry(proizvodi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProizvodiExists(id))
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
        // POST: api/Proizvodi
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult PostProizvodi(Proizvodi proizvodi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Proizvodi.Add(proizvodi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = proizvodi.ProizvodID }, proizvodi);
        }

        // DELETE: api/Proizvodi/5
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult DeleteProizvodi(int id)
        {
            Proizvodi proizvodi = db.Proizvodi.Find(id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            db.Proizvodi.Remove(proizvodi);
            db.SaveChanges();

            return Ok(proizvodi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProizvodiExists(int id)
        {
            return db.Proizvodi.Count(e => e.ProizvodID == id) > 0;
        }
    }
}