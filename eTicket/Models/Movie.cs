﻿using eTicket.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string MovieImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
