using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


    public class Wheel
    {
        public int Id { get; set; }
        public decimal WheelsSize { get; set; }
        public int Hardness { get; set; }
        public string WheelsShape { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public virtual ICollection<Skateboard> Skateboards { get; set; }
    }

