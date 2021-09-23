using System;

namespace CoffeeWebAPI
{
    public class CoffeeModel
    {
        public DateTime Date { get; set; }

        public int PriceBase { get; set; }

        public int PriceVND => 23000 * (int)(PriceBase-0.65217);

        public string Summary { get; set; }
    }
}
