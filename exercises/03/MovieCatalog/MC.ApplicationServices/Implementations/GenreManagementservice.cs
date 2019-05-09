using MC.ApplicationServices.DTOs;
using MC.Data.Contexts;
using MC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.ApplicationServices.Implementations
{
    public class GenreManagementService
    {
        private MovieCatalogDbContext ctx = new MovieCatalogDbContext();

        public List<GenreDto> Get()
        {
            List<GenreDto> genresDto = new List<GenreDto>();

            foreach (var item in ctx.Genres.ToList())
            {
                genresDto.Add(new GenreDto
                {
                    Name = item.Name
                });
            }

            return genresDto;
        }

        public bool Save(GenreDto genreDto)
        {
            Genre genre = new Genre
            {
                Name = genreDto.Name
            };

            ctx.Genres.Add(genre);
            ctx.SaveChanges();

            return true;

        }

        public bool Delete(int id)
        {
            try
            {
                Genre genre = ctx.Genres.Find(id);
                ctx.Genres.Remove(genre);
                ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
