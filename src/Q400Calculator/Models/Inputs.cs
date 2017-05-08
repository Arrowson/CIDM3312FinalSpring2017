using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace Q400Calculator.Models
{
    public class Inputs
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter the Aircraft Weight")]
        [Range(18000, 29000, ErrorMessage ="Weight must be between 18000 Kg to 29000 Kg")]
        [Display(Name = "Aircraft Weight")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Please enter the Runway Altitude")]
        [Range(0, 10000, ErrorMessage = "Runway Altitude must be between 0 M to 10000 M")]
        [Display(Name = "Runway Altitude")]
        public int Altitude { get; set; }

        [Required(ErrorMessage = "Please enter the Runway Direction")]
        [Range(1, 360, ErrorMessage = "Runway Direction must be between 1 and 360")]
        [Display(Name = "Runway Direction (Compass Degrees)")]
        public int RunwayDirection { get; set; }

        [Display(Name = "Are you Taking off?")]
        public bool TakeoffTrueFalse { get; set; }

        [Required(ErrorMessage = "Please enter the temperature outside")]
        [Range(-30, 55, ErrorMessage = "Temperature must be between -30 C to 55 C")]
        [Display(Name = "Outside Temperature (Celsius)")]
        public int Temperature { get; set; }

        [Display(Name = "Is there ice on the runway?")]
        public bool Icing { get; set; }

        [Display(Name = "Is it precipitating?")]
        public bool Precipitation { get; set; }

        [Required(ErrorMessage = "Please enter the Wind Direction")]
        [Range(1, 360, ErrorMessage = "Wind Direction must be between 1 and 360")]
        [Display(Name = "Wind Direction (Compass Degrees)")]
        public int WindDegrees { get; set; }

        [Required(ErrorMessage = "Please enter the Wind Speed")]
        [Range(0, 80, ErrorMessage = "Wind Speed must be between 0 Kts and 80 Kts")]
        [Display(Name = "Wind Speed (Knots)")]
        public int WindSpeed { get; set; }

        [Required(ErrorMessage = "Please enter the trip distance")]
        [Range(0, 1114, ErrorMessage = "Trip distance must be below 1114 NM")]
        [Display(Name = "Total Trip Distance")]
        public int TripDistance { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Pilot's Name")]
        public string Name { get; set; }
    }
}
