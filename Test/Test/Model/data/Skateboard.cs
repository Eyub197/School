using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


    public class Skateboard
    {

        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Hardware { get; set; }
        public DateTime DateOfProduction { get; set; }

        [ForeignKey("Deck")]
        public int DeckId { get; set; }
        public virtual Deck Deck { get; set; }

        [ForeignKey("Wheel")]
        public int WheelId { get; set; }
        public virtual Wheel Wheel { get; set; }

        [ForeignKey("Bearing")]
        public int BearingId { get; set; }
        public virtual Bearing Bearing { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }

