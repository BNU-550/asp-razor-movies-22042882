using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace razor_movies.Models
{
    public enum Genres
    {
        Horror, Comedy, Drama, Romance, Action, SciFi, Thriller, Animation, Family
    }

    public class movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]

        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres Genre { get; set; }
        public decimal Price { get; set; }
    }
}
