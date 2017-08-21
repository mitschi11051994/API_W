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
using API_W.Models;

namespace API_W.Controllers
{
    public class tblReunionsController : ApiController
    {
        private CMDEntities db = new CMDEntities();

        // GET: api/tblReunions
        public IQueryable<tblReunion> GettblReunion()
        {
            return db.tblReunion;
        }

        // GET: api/tblReunions/5
        [ResponseType(typeof(tblReunion))]
        public IHttpActionResult GettblReunion(int id)
        {
            tblReunion tblReunion = db.tblReunion.Find(id);
            if (tblReunion == null)
            {
                return NotFound();
            }

            return Ok(tblReunion);
        }

        // PUT: api/tblReunions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblReunion(int id, tblReunion tblReunion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblReunion.id_reunion)
            {
                return BadRequest();
            }

            db.Entry(tblReunion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblReunionExists(id))
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

        // POST: api/tblReunions
        [ResponseType(typeof(tblReunion))]
        public IHttpActionResult PosttblReunion(tblReunion tblReunion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblReunion.Add(tblReunion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblReunion.id_reunion }, tblReunion);
        }

        // DELETE: api/tblReunions/5
        [ResponseType(typeof(tblReunion))]
        public IHttpActionResult DeletetblReunion(int id)
        {
            tblReunion tblReunion = db.tblReunion.Find(id);
            if (tblReunion == null)
            {
                return NotFound();
            }

            db.tblReunion.Remove(tblReunion);
            db.SaveChanges();

            return Ok(tblReunion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblReunionExists(int id)
        {
            return db.tblReunion.Count(e => e.id_reunion == id) > 0;
        }
    }
}