using System;
using System.Collections.Generic;
using System.Text;


     public  class Bearing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AbecRating { get; set; }
        public string BearingMaterial { get; set; }

      // public virtual ICollection<Brand> Brands { get; set; }
        //public virtual Brand BrandId { get; set; } */
        public int BrandId { get; set; }
    }

