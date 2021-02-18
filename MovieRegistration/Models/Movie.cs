using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public enum Category
    {
        Comedy,
        Drama,
        Horror,
        Romance,
        Action,
        Indie,
        Adventure,
        Propaganda,
        Animation
    }
    public class Movie
    {

 
        public int ID { get; set; }
        public string Title { get; set; }
        public Category Genre { get; set; }
        public DateTime Year { get; set; }
        public List<string> Actors { get; set; }
        public List<string> Directors { get; set; }
    }
}
