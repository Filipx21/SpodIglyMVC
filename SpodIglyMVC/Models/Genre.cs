using System.Collections.Generic;

namespace SpodIglyMVC.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        public string IconFilename { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}