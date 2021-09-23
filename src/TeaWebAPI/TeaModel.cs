using System;

namespace TeaWebAPI
{
    public class TeaModel
    {
        public DateTime Date { get; set; }

        public int PriceBase { get; set; }

        public int PriceVND => 32 + (int)(PriceBase / 0.5556);

        public string Summary { get; set; }
    }
}
