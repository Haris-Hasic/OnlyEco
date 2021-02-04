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
    public class VrsteProizvodaController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/VrsteProizvoda
        [HttpGet]      
        public IQueryable<VrsteProizvoda> GetVrsteProizvoda()
        {
            return db.VrsteProizvoda.OrderBy(x =>x.Naziv);
        }
        [HttpGet]
        [Route("api/VrsteProizvoda/GetVrsta/{ID}")]
        [ResponseType(typeof(VrsteProizvoda))]
        public IHttpActionResult GetVrsta(int id)
        {
            VrsteProizvoda vrste = db.VrsteProizvoda.Find(id);
            if (vrste == null)
            {
                return NotFound();
            }

            return Ok(vrste);
        }
    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VrsteProizvodaExists(int id)
        {
            return db.VrsteProizvoda.Count(e => e.VrstaID == id) > 0;
        }
    }
}