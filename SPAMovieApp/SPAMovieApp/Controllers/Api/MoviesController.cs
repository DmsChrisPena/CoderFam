using SPAMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Routing;
using System.Net.Http;
using System.Web.Http;

namespace SPAMovieApp.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private MoviesContext _db = new MoviesContext();


        public IHttpActionResult Get()
        {
            return Ok(_db.Movies);
        }


        public IHttpActionResult Post(Movies movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _db.Movies.Add(movie);
            _db.SaveChanges();

            return Ok(new { success = "the request was successful"});
        }

        // DELETE: api/Movies/5
        public IHttpActionResult Delete(int id)
        {
            Movies movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            _db.Movies.Remove(movie);
            _db.SaveChanges();

            return Ok(movie);
        }

    }
}
