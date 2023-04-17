using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


    public class Deck
    {
        public int Id { get; set; }
        public string WoodType { get; set; }
        public string DeckShape { get; set; }
        public string DeckConcave { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public virtual ICollection<Skateboard> Skateboards { get; set; }
    }

