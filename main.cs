using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FuckIntakeOcclusion
{
    [KSPModule("Unoccludable Intake")]
    public class ModuleUnoccludableIntake : ModuleResourceIntake
    {
        public new void FixedUpdate()
        {
            part.ShieldedFromAirstream = false;
            base.FixedUpdate();
        }
    }
}