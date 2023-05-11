using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Skateboard
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        //външен ключ
        [ForeignKey(nameof(Deck))]
        public int DeckId { get; set; }


        [ForeignKey(nameof(Wheel))]

        public int WheelId { get; set; }

        public string Hardware { get; set; }

        [ForeignKey(nameof(Bearing))]

        public int BearingId;

        [ForeignKey(nameof(Brand))]

        public int BrandId { get; set; }

        public DateTime Date_of_production { get; set; }
        //навигационно св-во
        public Deck Deck { get; set; }
        public Wheel Wheel { get; set; }
        public Bearing Bearing { get; set; }
        public Brand Brand { get; set; }
    }
}
