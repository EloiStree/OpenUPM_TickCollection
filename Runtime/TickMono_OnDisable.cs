using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Tick
{

public class TickMono_OnDisable : TickMono_AbstractDefault
{

    private void OnDisable()
    {
        base.TriggerTick();
    }
}
}
