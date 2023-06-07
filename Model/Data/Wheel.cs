using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Wheel
    {
        public int Id { get; set; }
        public decimal Wheels_size { get; set; }
        public int Hardness { get; set; }
        public string Wheels_shape { get; set; }
        public ICollection<Skateboard> Skateboards { get; set; }

    }
}
