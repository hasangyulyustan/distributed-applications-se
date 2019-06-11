using System.ComponentModel.DataAnnotations;
using MC.Website.GenresReference;

namespace MC.Website.ViewModels
{
    public class GenreVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public GenreVM() { }

        public GenreVM(GenreDto genreDto)
        {
            Name = genreDto.Name;
        }
    }
}