using MC.Data.Contexts;
using MC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MC.WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Movies" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Movies.svc or Movies.svc.cs at the Solution Explorer and start debugging.
    public class Movies : IMovies
    {
        private MovieCatalogDbContext ctx = new MovieCatalogDbContext();

        public List<Movie> GetMovies()
        {
            return ctx.Movies.ToList();
        }

        public string PostMovie(Movie movie)
        {
            ctx.Movies.Add(movie);
            ctx.SaveChanges();

            return "Movie is inserted";
        }

        public string PutMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public string DeleteMovie(int id)
        {
            try
            {
                Movie movie = ctx.Movies.Find(id);
                ctx.Movies.Remove(movie);
                ctx.SaveChanges();

                return "Movie is deleted";
            }
            catch
            {
                return "Movie is not deleted";
            }
            

           
        }
    }
}
