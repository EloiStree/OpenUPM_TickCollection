using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Tick
{

public class TickMono_OnDestroy : TickMono_AbstractDefault
{

    void OnDestroy()
    {
        base.TriggerTick();
    }
   
}

}