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
    public class tblSupport_TicketsController : ApiController
    {
        private CMDEntities db = new CMDEntities();

        // GET: api/tblSupport_Tickets
        public IQueryable<tblSupport_Tickets> GettblSupport_Tickets()
        {
            return db.tblSupport_Tickets;
        }

        // GET: api/tblSupport_Tickets/5
        [ResponseType(typeof(tblSupport_Tickets))]
        public IHttpActionResult GettblSupport_Tickets(int id)
        {
            tblSupport_Tickets tblSupport_Tickets = db.tblSupport_Tickets.Find(id);
            if (tblSupport_Tickets == null)
            {
                return NotFound();
            }

            return Ok(tblSupport_Tickets);
        }

        // PUT: api/tblSupport_Tickets/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblSupport_Tickets(int id, tblSupport_Tickets tblSupport_Tickets)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblSupport_Tickets.id_Support_Tickets)
            {
                return BadRequest();
            }

            db.Entry(tblSupport_Tickets).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblSupport_TicketsExists(id))
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

        // POST: api/tblSupport_Tickets
        [ResponseType(typeof(tblSupport_Tickets))]
        public IHttpActionResult PosttblSupport_Tickets(tblSupport_Tickets tblSupport_Tickets)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblSupport_Tickets.Add(tblSupport_Tickets);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblSupport_Tickets.id_Support_Tickets }, tblSupport_Tickets);
        }

        // DELETE: api/tblSupport_Tickets/5
        [ResponseType(typeof(tblSupport_Tickets))]
        public IHttpActionResult DeletetblSupport_Tickets(int id)
        {
            tblSupport_Tickets tblSupport_Tickets = db.tblSupport_Tickets.Find(id);
            if (tblSupport_Tickets == null)
            {
                return NotFound();
            }

            db.tblSupport_Tickets.Remove(tblSupport_Tickets);
            db.SaveChanges();

            return Ok(tblSupport_Tickets);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblSupport_TicketsExists(int id)
        {
            return db.tblSupport_Tickets.Count(e => e.id_Support_Tickets == id) > 0;
        }
    }
}