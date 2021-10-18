using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DailyNutrition
{
    public class NutritionBase
    {
        [DisplayName("Beskrivning")]
        public string Description { get; set; }
        [DisplayName("Datum")]
        public DateTime Date { get; set; }
        [DisplayName("Portion")]
        public double Portion { get; set; }
        [DisplayName("Vätska")]
        public string Beverage { get; set; }
        [DisplayName("Volym")]
        public int Volym { get; set; }
    }
}
