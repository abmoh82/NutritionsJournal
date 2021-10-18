using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DailyNutrition.Models
{
    public class Breakfast : NutritionBase
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Det är obligatorisk med vitamin d")]
        [DisplayName("Vitamin intag")]
        public bool D_Vitamin_Intake { get; set; }
    }
}
