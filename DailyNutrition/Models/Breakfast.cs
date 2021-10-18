using System;
using System.ComponentModel;

namespace DailyNutrition.Models
{
    public class Breakfast : NutritionBase
    {
        public int ID { get; set; }
        [DisplayName("Vitamin intag")]
        public bool D_Vitamin_Intake { get; set; }
    }
}
