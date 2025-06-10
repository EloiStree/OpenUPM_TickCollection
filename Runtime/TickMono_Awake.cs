using System.Collections;
using System.Collections.Generic;
namespace Eloi.Tick
{
    public class TickMono_Awake : TickMono_AbstractDefault
    {
        void Start()
        {
            base.TriggerTick();
        }
    }
  

}