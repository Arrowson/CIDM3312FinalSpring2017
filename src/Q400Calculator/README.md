# Airplane Calculator
---

Aaron Lisle Williamson <br>
Created Spring 2017 <br>
Edited README Summer 2018<br>

---
### Overview
This program acted as the final for an advanced business programming class in the Spring of 2017. <br>
Essentially, the program dealt with many *MANY* aspects of an airplane, and calculated the correct <br>
speed for takeoff or landing under many different situtions.

---
### Aspects
These conditions included the following and many more.

+ Whether or not there was rain currently
+ The current Temperature
+ The altitude of the Airplane
+ The type of aircraft itself
+ The current wind speed and direction
<br>
This is not a comprehensive list by all means, but it serves the purpose of demonstrating that this is <br>
an in depth application that could, potentially, have real world applications.
---
### Result
To my knowledge, the calculations were all correct and executed timely. This is especially important for <br>
an application such as this. There were various sections of the code that threw me for a loop. The most notable <br>
example would be finding the correct wind direction and determining if it was a headwind, tailwind or crosswind. <br>

```
[Required(ErrorMessage = "Please enter the Wind Direction")]
        [Range(1, 360, ErrorMessage = "Wind Direction must be between 1 and 360")]
        [Display(Name = "Wind Direction (Compass Degrees)")]
        public int WindDegrees { get; set; }

        [Required(ErrorMessage = "Please enter the Wind Speed")]
        [Range(0, 80, ErrorMessage = "Wind Speed must be between 0 Kts and 80 Kts")]
        [Display(Name = "Wind Speed (Knots)")]
        public int WindSpeed { get; set; }
```
This is where the user input the wind direction and speed, which were sent to the controller to determine (based <br>
on compass degrees and the direction of flight) how much the wind would change the takeoff or landing speed.
