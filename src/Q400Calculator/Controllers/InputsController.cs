using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Data;
using Q400Calculator.Models;

namespace Q400Calculator.Controllers
{
    public class InputsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InputsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Inputs1
        public async Task<IActionResult> Index()
        {
            

            return View(await _context.Inputs.ToListAsync());
        }

        // GET: Inputs1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (inputs == null)
            {
                return NotFound();
            }

            return View(inputs);
        }

        // GET: Inputs1/Create
        
        public async Task<IActionResult> Create()
        {
            Inputs I = new Models.Inputs();

            I.LandingFlaps10 = await _context.LandingFlaps10.ToListAsync();
            I.LandingFlaps15 = await _context.LandingFlaps15.ToListAsync();
            I.LandingFlaps35 = await _context.LandingFlaps35.ToListAsync();
            I.LandingFlaps5 = await _context.LandingFlaps5.ToListAsync();

            I.TakeoffFlaps10Above20 = await _context.TakeoffFlaps10Above20.ToListAsync();
            I.TakeoffFlaps10Below20 = await _context.TakeoffFlaps10Below20.ToListAsync();
            I.TakeoffFlaps15Above20 = await _context.TakeoffFlaps15Above20.ToListAsync();
            I.TakeoffFlaps15Below20 = await _context.TakeoffFlpas15Below20.ToListAsync();
            I.TakeoffFlaps5Above20 = await _context.TakeoffFlaps5Above20.ToListAsync();
            I.TakeoffFlaps5Below20 = await _context.TakeoffFlaps5Above5Below20Data.ToListAsync();

            I.ClimbData = await _context.ClimbData.ToListAsync();
            return View(I);
        }

        
        // POST: Inputs1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, FlapsSettings, Weight, Altitude, RunwayDirection, TakeoffTrueFalse, Temperature, Icing, Precipitaion, WindDegrees, WindSpeed, TripDistance, Name, ClimbData, LandingFlaps10, LandingFlaps15, LandingFlaps35, LandingFlaps5, TakeoffFlaps10Above20, TakeoffFlaps10Below20, TakeoffFlaps15Above20, TakeoffFlaps15Below20, TakeoffFlaps5Above20, TakeoffFlaps5Below20 ")] Inputs inputs)
        {
           

            //make sure there is nothing null, like defaults
            

            

            if (ModelState.IsValid)
            {
                _context.Add(inputs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(inputs);
        }

        // GET: Inputs1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (inputs == null)
            {
                return NotFound();
            }
            return View(inputs);
        }

        // POST: Inputs1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Altitude,Icing,Name,Precipitation,RunwayDirection,TakeoffTrueFalse,Temperature,TripDistance,Weight,WindDegrees,WindSpeed")] Inputs inputs)
        {
            if (id != inputs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inputs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InputsExists(inputs.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(inputs);
        }

        // GET: Inputs1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (inputs == null)
            {
                return NotFound();
            }

            return View(inputs);
        }

        // POST: Inputs1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            _context.Inputs.Remove(inputs);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> Outputs(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var I = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == id);
            if (I == null)
            {
                return NotFound();
            }
            //find weight at landing
            I.LandingWeight = I.Weight - ((I.TripDistance / 600) * 2163);
            
            
            I.LandingFlaps10 = await _context.LandingFlaps10.ToListAsync();
            I.LandingFlaps15 = await _context.LandingFlaps15.ToListAsync();
            I.LandingFlaps35 = await _context.LandingFlaps35.ToListAsync();
            I.LandingFlaps5 = await _context.LandingFlaps5.ToListAsync();

            I.TakeoffFlaps10Above20 = await _context.TakeoffFlaps10Above20.ToListAsync();
            I.TakeoffFlaps10Below20 = await _context.TakeoffFlaps10Below20.ToListAsync();
            I.TakeoffFlaps15Above20 = await _context.TakeoffFlaps15Above20.ToListAsync();
            I.TakeoffFlaps15Below20 = await _context.TakeoffFlpas15Below20.ToListAsync();
            I.TakeoffFlaps5Above20 = await _context.TakeoffFlaps5Above20.ToListAsync();
            I.TakeoffFlaps5Below20 = await _context.TakeoffFlaps5Above5Below20Data.ToListAsync();

            I.ClimbData = await _context.ClimbData.ToListAsync();


            //round weight to correct amount
            int finishedWeight = I.Weight;
            if (finishedWeight < 19000)
            {
                finishedWeight = 18000;
                goto done;
            }
            else if (finishedWeight < 21000)
            {
                finishedWeight = 20000;
                goto done;
            }
            else if (finishedWeight < 23000)
            {
                finishedWeight = 22000;
                goto done;
            }
            else if (finishedWeight < 25000)
            {
                finishedWeight = 24000;
                goto done;
            }
            else if (finishedWeight < 27000)
            {
                finishedWeight = 26000;
                goto done;
            }
            else if (finishedWeight < 28500)
            {
                finishedWeight = 28000;
                goto done;
            }
            else
            {
                finishedWeight = 29000;
                goto done;
            }
            done:;

            int RoundedAltitude = I.Altitude;
            if (RoundedAltitude < 1000)
            {
                RoundedAltitude = 0;
                goto altitudeRounded;
            }
            else if (RoundedAltitude < 3000)
            {
                RoundedAltitude = 2000;
                goto altitudeRounded;
            }
            else if (RoundedAltitude < 5000)
            {
                RoundedAltitude = 4000;
                goto altitudeRounded;
            }
            else if (RoundedAltitude < 7000)
            {
                RoundedAltitude = 6000;
                goto altitudeRounded;
            }
            else if (RoundedAltitude < 9000)
            {
                RoundedAltitude = 8000;
                goto altitudeRounded;
            }
            else
            {
                RoundedAltitude = 10000;
                goto altitudeRounded;
            }
            altitudeRounded:;
            //find table and row
            for (int i = 0; i < I.ClimbData.Count - 1; i++)
            {
                if (I.ClimbData[i].Weight == finishedWeight)
                {
                    I.SelectedWeight = i;
                    break;
                }
            }

            //for climbdata
            if (I.FlapsSettings == 5)
            {
                I.VClimb = I.ClimbData[I.SelectedWeight].Vclmb;
                I.VFri = I.ClimbData[I.SelectedWeight].Vfri5;
            }
            else if (I.FlapsSettings == 10)
            {
                I.VClimb = I.ClimbData[I.SelectedWeight].Vclmb;
                I.VFri = I.ClimbData[I.SelectedWeight].Vfri10;
            }
            else if (I.FlapsSettings == 15)
            {
                I.VClimb = I.ClimbData[I.SelectedWeight].Vclmb;
                I.VFri = I.ClimbData[I.SelectedWeight].Vfri15;
            }

            //for all takeoff data
            if (I.Temperature <= 20)
            {
                if (I.FlapsSettings == 5)
                {
                    if (RoundedAltitude == 0)
                    {
                        I.Vr = I.TakeoffFlaps5Below20[I.SelectedWeight].Vr0;
                        I.V2 = I.TakeoffFlaps5Below20[I.SelectedWeight].V20;
                    }
                    else if (RoundedAltitude == 2000)
                    {
                        I.Vr = I.TakeoffFlaps5Below20[I.SelectedWeight].Vr2000;
                        I.V2 = I.TakeoffFlaps5Below20[I.SelectedWeight].V22000;
                    }
                    else if (RoundedAltitude == 4000)
                    {
                        I.Vr = I.TakeoffFlaps5Below20[I.SelectedWeight].Vr4000;
                        I.V2 = I.TakeoffFlaps5Below20[I.SelectedWeight].V24000;
                    }
                    else if (RoundedAltitude == 6000)
                    {
                        I.Vr = I.TakeoffFlaps5Below20[I.SelectedWeight].Vr6000;
                        I.V2 = I.TakeoffFlaps5Below20[I.SelectedWeight].V26000;
                    }
                    else if (RoundedAltitude == 8000)
                    {
                        I.Vr = I.TakeoffFlaps5Below20[I.SelectedWeight].Vr8000;
                        I.V2 = I.TakeoffFlaps5Below20[I.SelectedWeight].V28000;
                    }
                    else if (RoundedAltitude == 10000)
                    {
                        I.Vr = I.TakeoffFlaps5Below20[I.SelectedWeight].Vr10000;
                        I.V2 = I.TakeoffFlaps5Below20[I.SelectedWeight].v210000;
                    }
                }
                else if (I.FlapsSettings == 10)
                {
                    if (RoundedAltitude == 0)
                    {
                        I.Vr = I.TakeoffFlaps10Below20[I.SelectedWeight].Vr0;
                        I.V2 = I.TakeoffFlaps10Below20[I.SelectedWeight].V20;
                    }
                    else if (RoundedAltitude == 2000)
                    {
                        I.Vr = I.TakeoffFlaps10Below20[I.SelectedWeight].Vr2000;
                        I.V2 = I.TakeoffFlaps10Below20[I.SelectedWeight].V22000;
                    }
                    else if (RoundedAltitude == 4000)
                    {
                        I.Vr = I.TakeoffFlaps10Below20[I.SelectedWeight].Vr4000;
                        I.V2 = I.TakeoffFlaps10Below20[I.SelectedWeight].V24000;
                    }
                    else if (RoundedAltitude == 6000)
                    {
                        I.Vr = I.TakeoffFlaps10Below20[I.SelectedWeight].Vr6000;
                        I.V2 = I.TakeoffFlaps10Below20[I.SelectedWeight].V26000;
                    }
                    else if (RoundedAltitude == 8000)
                    {
                        I.Vr = I.TakeoffFlaps10Below20[I.SelectedWeight].Vr8000;
                        I.V2 = I.TakeoffFlaps10Below20[I.SelectedWeight].V28000;
                    }
                    else if (RoundedAltitude == 10000)
                    {
                        I.Vr = I.TakeoffFlaps10Below20[I.SelectedWeight].Vr10000;
                        I.V2 = I.TakeoffFlaps10Below20[I.SelectedWeight].v210000;
                    }
                }
                else if (I.FlapsSettings == 15)
                {
                    if (RoundedAltitude == 0)
                    {
                        I.Vr = I.TakeoffFlaps15Below20[I.SelectedWeight].Vr0;
                        I.V2 = I.TakeoffFlaps15Below20[I.SelectedWeight].V20;
                    }
                    else if (RoundedAltitude == 2000)
                    {
                        I.Vr = I.TakeoffFlaps15Below20[I.SelectedWeight].Vr2000;
                        I.V2 = I.TakeoffFlaps15Below20[I.SelectedWeight].V22000;
                    }
                    else if (RoundedAltitude == 4000)
                    {
                        I.Vr = I.TakeoffFlaps15Below20[I.SelectedWeight].Vr4000;
                        I.V2 = I.TakeoffFlaps15Below20[I.SelectedWeight].V24000;
                    }
                    else if (RoundedAltitude == 6000)
                    {
                        I.Vr = I.TakeoffFlaps15Below20[I.SelectedWeight].Vr6000;
                        I.V2 = I.TakeoffFlaps15Below20[I.SelectedWeight].V26000;
                    }
                    else if (RoundedAltitude == 8000)
                    {
                        I.Vr = I.TakeoffFlaps15Below20[I.SelectedWeight].Vr8000;
                        I.V2 = I.TakeoffFlaps15Below20[I.SelectedWeight].V28000;
                    }
                    else if (RoundedAltitude == 10000)
                    {
                        I.Vr = I.TakeoffFlaps15Below20[I.SelectedWeight].Vr10000;
                        I.V2 = I.TakeoffFlaps15Below20[I.SelectedWeight].v210000;
                    }
                }
            }
            else
            {
                if (I.FlapsSettings == 5)
                {
                    if (RoundedAltitude == 0)
                    {
                        I.Vr = I.TakeoffFlaps5Above20[I.SelectedWeight].Vr0;
                        I.V2 = I.TakeoffFlaps5Above20[I.SelectedWeight].V20;
                    }
                    else if (RoundedAltitude == 2000)
                    {
                        I.Vr = I.TakeoffFlaps5Above20[I.SelectedWeight].Vr2000;
                        I.V2 = I.TakeoffFlaps5Above20[I.SelectedWeight].V22000;
                    }
                    else if (RoundedAltitude == 4000)
                    {
                        I.Vr = I.TakeoffFlaps5Above20[I.SelectedWeight].Vr4000;
                        I.V2 = I.TakeoffFlaps5Above20[I.SelectedWeight].V24000;
                    }
                    else if (RoundedAltitude == 6000)
                    {
                        I.Vr = I.TakeoffFlaps5Above20[I.SelectedWeight].Vr6000;
                        I.V2 = I.TakeoffFlaps5Above20[I.SelectedWeight].V26000;
                    }
                    else if (RoundedAltitude == 8000)
                    {
                        I.Vr = I.TakeoffFlaps5Above20[I.SelectedWeight].Vr8000;
                        I.V2 = I.TakeoffFlaps5Above20[I.SelectedWeight].V28000;
                    }
                    else if (RoundedAltitude == 10000)
                    {
                        I.Vr = I.TakeoffFlaps5Above20[I.SelectedWeight].Vr10000;
                        I.V2 = I.TakeoffFlaps5Above20[I.SelectedWeight].v210000;
                    }
                }
                else if (I.FlapsSettings == 10)
                {
                    if (RoundedAltitude == 0)
                    {
                        I.Vr = I.TakeoffFlaps10Above20[I.SelectedWeight].Vr0;
                        I.V2 = I.TakeoffFlaps10Above20[I.SelectedWeight].V20;
                    }
                    else if (RoundedAltitude == 2000)
                    {
                        I.Vr = I.TakeoffFlaps10Above20[I.SelectedWeight].Vr2000;
                        I.V2 = I.TakeoffFlaps10Above20[I.SelectedWeight].V22000;
                    }
                    else if (RoundedAltitude == 4000)
                    {
                        I.Vr = I.TakeoffFlaps10Above20[I.SelectedWeight].Vr4000;
                        I.V2 = I.TakeoffFlaps10Above20[I.SelectedWeight].V24000;
                    }
                    else if (RoundedAltitude == 6000)
                    {
                        I.Vr = I.TakeoffFlaps10Above20[I.SelectedWeight].Vr6000;
                        I.V2 = I.TakeoffFlaps10Above20[I.SelectedWeight].V26000;
                    }
                    else if (RoundedAltitude == 8000)
                    {
                        I.Vr = I.TakeoffFlaps10Above20[I.SelectedWeight].Vr8000;
                        I.V2 = I.TakeoffFlaps10Above20[I.SelectedWeight].V28000;
                    }
                    else if (RoundedAltitude == 10000)
                    {
                        I.Vr = I.TakeoffFlaps10Above20[I.SelectedWeight].Vr10000;
                        I.V2 = I.TakeoffFlaps10Above20[I.SelectedWeight].v210000;
                    }
                }
                else if (I.FlapsSettings == 15)
                {
                    if (RoundedAltitude == 0)
                    {
                        I.Vr = I.TakeoffFlaps15Above20[I.SelectedWeight].Vr0;
                        I.V2 = I.TakeoffFlaps15Above20[I.SelectedWeight].V20;
                    }
                    else if (RoundedAltitude == 2000)
                    {
                        I.Vr = I.TakeoffFlaps15Above20[I.SelectedWeight].Vr2000;
                        I.V2 = I.TakeoffFlaps15Above20[I.SelectedWeight].V22000;
                    }
                    else if (RoundedAltitude == 4000)
                    {
                        I.Vr = I.TakeoffFlaps15Above20[I.SelectedWeight].Vr4000;
                        I.V2 = I.TakeoffFlaps15Above20[I.SelectedWeight].V24000;
                    }
                    else if (RoundedAltitude == 6000)
                    {
                        I.Vr = I.TakeoffFlaps15Above20[I.SelectedWeight].Vr6000;
                        I.V2 = I.TakeoffFlaps15Above20[I.SelectedWeight].V26000;
                    }
                    else if (RoundedAltitude == 8000)
                    {
                        I.Vr = I.TakeoffFlaps15Above20[I.SelectedWeight].Vr8000;
                        I.V2 = I.TakeoffFlaps15Above20[I.SelectedWeight].V28000;
                    }
                    else if (RoundedAltitude == 10000)
                    {
                        I.Vr = I.TakeoffFlaps15Above20[I.SelectedWeight].Vr10000;
                        I.V2 = I.TakeoffFlaps15Above20[I.SelectedWeight].v210000;
                    }
                }
            }

            //for all landing data

            int finishedLandingWeight = I.LandingWeight;
            if (finishedLandingWeight < 19000)
            {
                finishedLandingWeight = 18000;
            }
            else if (finishedLandingWeight < 21000)
            {
                finishedLandingWeight = 20000;
            }
            else if (finishedLandingWeight < 23000)
            {
                finishedLandingWeight = 22000;
            }
            else if (finishedLandingWeight < 25000)
            {
                finishedLandingWeight = 24000;
            }
            else if (finishedLandingWeight < 27000)
            {
                finishedLandingWeight = 26000;
            }
            else if (finishedLandingWeight < 28500)
            {
                finishedLandingWeight = 28000;
            }
            else
            {
                finishedLandingWeight = 29000;
            }

            I.LandingWeight = finishedLandingWeight;

            for (int i = 0; i < I.ClimbData.Count - 1; i++)
            {
                if (I.ClimbData[i].Weight == I.LandingWeight)
                {
                    I.SelectedWeight = i;
                    break;
                }
            }



            if (I.FlapsSettings == 5)
            {
                I.Vapp = I.LandingFlaps5[I.SelectedWeight].VApp;
                I.Vref = I.LandingFlaps5[I.SelectedWeight].VRef;
                I.Vga = I.LandingFlaps5[I.SelectedWeight].Vga;
            }
            else if (I.FlapsSettings == 10)
            {
                I.Vapp = I.LandingFlaps10[I.SelectedWeight].VApp;
                I.Vref = I.LandingFlaps10[I.SelectedWeight].VRef;
                I.Vga = I.LandingFlaps10[I.SelectedWeight].Vga;
            }
            else if (I.FlapsSettings == 15)
            {
                I.Vapp = I.LandingFlaps15[I.SelectedWeight].VApp;
                I.Vref = I.LandingFlaps15[I.SelectedWeight].VRef;
                I.Vga = I.LandingFlaps15[I.SelectedWeight].Vga;
            }


            //Assume that V1 is the same as VR
            I.V1 = I.Vr;

            //If VR exceeds V2, use VR for both
            if (I.Vr > I.V2)
            {
                I.V2 = I.Vr;
            }

            //If the OAT is 10C or below in rain, assume icing
            if (I.Temperature <= 10 && I.Precipitation == true)
            {
                I.Icing = true;
            }

            //If OAT is 0C, it is snowing, which causes no icing
            if (I.Temperature == 0 && I.Precipitation == true)
            {
                I.Icing = false;
            }

            //If icing protection is on
            //For takeoff, add 20kts to V2, V FRI, and V CLMB
            //For landing, add 20kts to Vapp, Vref, and Vga for flaps 10, 15, and 35
            if (I.Icing == true)
            {
                I.V2 += 20;
                I.VFri += 20;
                I.VClimb += 20;
                I.Vapp += 20;
                I.Vref += 20;
                I.Vga += 20;
            }

            //Assign Tailwind 
            Random rand = new Random();
            if (rand.Next(1, 10) == 5)
            {
                I.IsTailwind = true;
            }

            //find wind component

            if (I.WindDegrees - I.RunwayDirection > 0)
            {
                I.WindComponent = I.WindDegrees - I.RunwayDirection;
            }
            else
            {
                I.WindComponent = I.WindSpeed * (Math.Cos(360 + (I.WindDegrees - I.RunwayDirection)));
            }
            //If the runway is wet
            //Reduce V1 by 8 kts - 0.1 kts for every knot of headwind
            //Reduce V1 by 8 kts + 0.3 ktsfor every knot of tailwind
            if (I.Icing == false && I.Precipitation == true)
            {
                if (I.IsTailwind == true)
                {
                    I.V1 = (int)(I.V1 - 8 * (.3 * I.WindSpeed));
                }
                else
                {
                    I.V1 = (int)(I.V1 - 8 * (.1 * I.WindSpeed));
                }
            }

            //the minimums

            if (I.FlapsSettings == 5 && I.Vr < 108)
            {
                I.Vr = 108;
            }
            if (I.FlapsSettings == 10 && I.Vr < 104)
            {
                I.Vr = 104;
            }
            if (I.FlapsSettings == 15 && I.Vr < 100)
            {
                I.Vr = 100;
            }

            if (I.FlapsSettings == 5 && I.V1 < 97)
            {
                I.V1 = 97;
            }
            else if (I.V1 < 96)
            {
                I.V1 = 96;
            }
             
            return View(I);
            
           
            /*
            
            if (I.ID == null)
            {
                return NotFound();
            }

            var inputs = await _context.Inputs.SingleOrDefaultAsync(m => m.ID == I.ID);

            if (inputs == null)
            {
                return NotFound();
            }
            

            return View(inputs);
            */
        }

        private bool InputsExists(int id)
        {
            return _context.Inputs.Any(e => e.ID == id);
        }
    }
}
