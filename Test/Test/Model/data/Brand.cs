using System;
using System.Collections.Generic;
using System.Text;


    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Bearing> Bearings { get; set; }
        public virtual ICollection<Deck> Decks { get; set; }
        public virtual ICollection<Wheel> Wheels { get; set; }
        public virtual ICollection<Skateboard> Skateboards { get; set; }
    }

