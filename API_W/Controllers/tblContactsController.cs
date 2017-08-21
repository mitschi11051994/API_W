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
    public class tblContactsController : ApiController
    {
        private CMDEntities db = new CMDEntities();

        // GET: api/tblContacts
        public IQueryable<tblContact> GettblContact()
        {
            return db.tblContact;
        }

        // GET: api/tblContacts/5
        [ResponseType(typeof(tblContact))]
        public IHttpActionResult GettblContact(int id)
        {
            tblContact tblContact = db.tblContact.Find(id);
            if (tblContact == null)
            {
                return NotFound();
            }

            return Ok(tblContact);
        }

        // PUT: api/tblContacts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblContact(int id, tblContact tblContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblContact.id_contact)
            {
                return BadRequest();
            }

            db.Entry(tblContact).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblContactExists(id))
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

        // POST: api/tblContacts
        [ResponseType(typeof(tblContact))]
        public IHttpActionResult PosttblContact(tblContact tblContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblContact.Add(tblContact);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblContact.id_contact }, tblContact);
        }

        // DELETE: api/tblContacts/5
        [ResponseType(typeof(tblContact))]
        public IHttpActionResult DeletetblContact(int id)
        {
            tblContact tblContact = db.tblContact.Find(id);
            if (tblContact == null)
            {
                return NotFound();
            }

            db.tblContact.Remove(tblContact);
            db.SaveChanges();

            return Ok(tblContact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblContactExists(int id)
        {
            return db.tblContact.Count(e => e.id_contact == id) > 0;
        }
    }
}