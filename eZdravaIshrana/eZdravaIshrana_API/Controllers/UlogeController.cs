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
    public class UlogeController : ApiController
    {
        private eZdravaIshranaEntities db = new eZdravaIshranaEntities();

        // GET: api/Uloge
        public IQueryable<Uloge> GetUloge()
        {
            return db.Uloge.OrderBy(x=>x.Naziv);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlogeExists(int id)
        {
            return db.Uloge.Count(e => e.UlogaID == id) > 0;
        }
    }
}