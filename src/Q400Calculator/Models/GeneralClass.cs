using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q400Calculator.Models
{
    public class GeneralClass
    {
        public ClimbData SelectedClimbData { get; set;}
        public Inputs SelectedInputs { get; set; }
        public LandingFlaps10 SelectedLandingFlaps10 { get; set; }
        public LandingFlaps15 SelectedLandingFlaps15 { get; set; }
        public LandingFlaps35 SelectedLandingFlaps35 { get; set; }
        public LandingFlaps5 SelectedLandingFlaps5 { get; set; }
        public TakeoffFlaps10Above20 SelectedTakeoffFlaps10Above20 { get; set; }
        public TakeoffFlaps10Below20Data SelectedTakeoffFlaps10Below20Data { get; set; }
        public TakeoffFlaps15Above20 SelectedTakeoffFlaps15Above20 { get; set; }
        public TakeoffFlaps15Below20Data SelectedTakeoffFlaps15Below20Data { get; set; }
        public TakeoffFlaps5Above20Data SelectedTakeoffFlaps5Above20Data { get; set; }
        public TakeoffFlaps5Above5Below20Data SelectedTakeoffFlaps5Above5Below20Data { get; set; }
    }
}
