using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Tick
{

public class TickMono_OnEnable : TickMono_AbstractDefault
{

    private void OnEnable()
    {
        base.TriggerTick();
    }
}
}
