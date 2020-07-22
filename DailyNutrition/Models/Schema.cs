using System;

namespace DailyNutrition.Models
{
    public class Schema
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int FeedingDuration { get; set; }
        public int FormulaAmount { get; set; }
    }
}
