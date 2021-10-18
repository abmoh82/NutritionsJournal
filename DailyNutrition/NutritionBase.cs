using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DailyNutrition
{
    public class NutritionBase
    {
        [Required]
        [DisplayName("Beskrivning")]
        public string Description { get; set; }
        [DisplayName("Datum")]
        public DateTime Date { get; set; }
        [DisplayName("Portion")]
        public double Portion { get; set; }
        [DisplayName("Vätska")]
        public string Beverage { get; set; }
        [DisplayName("Volym i ml")]
        public int? Volym { get; set; }
    }
}
