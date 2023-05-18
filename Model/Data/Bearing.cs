using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Bearing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Abec_ratiang { get; set; }
        public string Bearing_material { get; set; }
        public ICollection<Skateboard> Skateboards { get; set; }
    }
}
