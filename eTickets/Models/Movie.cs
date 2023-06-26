﻿using eFarm.Data;
using eFarm.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eFarm.Models
{
    public class Movie:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Producator
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Producator Producator { get; set; }

        //Courier
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Courier Courier { get; set; }
    }
}
