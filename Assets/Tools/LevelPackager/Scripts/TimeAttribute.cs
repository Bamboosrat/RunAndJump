using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunAndJump.LevelCreator
{
    public class TimeAttribute : PropertyAttribute
    {
        public readonly bool DisplayHours;

        public TimeAttribute(bool displayHours = false)
        {
            DisplayHours = displayHours;
        }
    }
}
