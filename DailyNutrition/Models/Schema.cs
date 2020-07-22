using System;

namespace DailyNutrition.Models
{
    public class Schema
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int FeedingDuration { get; set; }
        public string Description { get; set; }
        public int FormulaAmount { get; set; }
        public bool D_Vitamin_Intake { get; set; }
    }
}
