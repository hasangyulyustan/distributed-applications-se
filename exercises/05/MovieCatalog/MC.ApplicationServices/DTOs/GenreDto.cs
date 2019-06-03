using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.ApplicationServices.DTOs
{
    public class GenreDto : IValidate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Validate()
        {
            return !String.IsNullOrEmpty(Name);
        }
    }
}
