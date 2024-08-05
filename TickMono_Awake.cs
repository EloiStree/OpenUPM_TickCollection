using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TickMono_Awake : TickMono_AbstractDefault
{
    void Start()
    {
        base.TriggerTick();
    }
}
