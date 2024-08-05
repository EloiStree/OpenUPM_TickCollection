using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickMono_OnDestroy : TickMono_AbstractDefault
{

    void OnDestroy()
    {
        base.TriggerTick();
    }
   
}
