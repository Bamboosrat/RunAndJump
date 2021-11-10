using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RunAndJump.LevelCreator;


public class TimeDrawerDemo : MonoBehaviour
{
    [Time]
    public int TimeMinutes = 3600;
    [Time(true)]
    public int TimeHours = 3600;
    [Time]
    public int TimeError = 3600;
}