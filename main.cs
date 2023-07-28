using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NoIntakeOcclusion
{
    [KSPModule("Unoccludable Intake")]
    public class ModuleUnoccludableIntake : ModuleResourceIntake
    {
        [KSPField(guiName = "Active while Shielded", isPersistant = true, guiActiveEditor = true, guiActive = false)]
        [UI_Toggle(enabledText = "Enabled", disabledText = "Disabled")]
        public bool enableShielded = false;

        public new void FixedUpdate()
        {
            if (enableShielded) part.ShieldedFromAirstream = false;
            base.FixedUpdate();
        }
    }
}