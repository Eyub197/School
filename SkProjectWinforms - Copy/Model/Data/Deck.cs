using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Deck
    {
        public int Id { get; set; }
        public string Wood_type { get; set; }
        public string Deck_shape { get; set; }
        public string Deck_concave { get; set; }
        public ICollection<Skateboard> Skateboards { get; set; }
    }
}
