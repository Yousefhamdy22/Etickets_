using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Etickets_.Data.Enum;
using Etickets_.Data.Base;
using Microsoft.DotNet.Cli.Utils;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etickets_.Models
{
    public class Movie : IEntityBase
    {


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
          //public MoveCategory moveCategory { get; set; }

        // Reltion 
        public List<Actor_MOvie> Actors_Movies { get; set; }


     public Movecategory Movecategory { get; set; }
        public List<Actor_MOvie> Actor_MOvies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public producer Producer { get; set; }

    }
}
