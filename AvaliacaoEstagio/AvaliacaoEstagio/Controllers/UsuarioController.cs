using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AvaliacaoEstagio.Models;

namespace AvaliacaoEstagio.Controllers
{
    /// <summary>
    /// Controller para consumir a API
    /// </summary>
    [RoutePrefix("API/Usuarios")]
    public class UsuarioController : ApiController
    {
       
        private ModelDB db = new ModelDB();
       
        //GET
        [HttpGet]
        [Route("Get")]
        public IQueryable<tbUsuario> Get()
        {
            return db.tbUsuarios;
            
        }
        //PUT
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttbUsuario(int id, tbUsuario tbUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbUsuario.IdUsuario)
            {
                return BadRequest();
            }

            db.Entry(tbUsuario).State = EntityState.Modified;


            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST
        [ResponseType(typeof(tbUsuario))]
        public IHttpActionResult PosttbUsuario(tbUsuario tbUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbUsuarios.Add(tbUsuario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tbUsuario.IdUsuario }, tbUsuario);
        }

        // DELETE
        [ResponseType(typeof(tbUsuario))]
        public IHttpActionResult DeletetbUsuario(int id)
        {
            tbUsuario tbUsuario = db.tbUsuarios.Find(id);
            if (tbUsuario == null)
            {
                return NotFound();
            }

            db.tbUsuarios.Remove(tbUsuario);
            db.SaveChanges();

            return Ok(tbUsuario);
        }

    }
}
