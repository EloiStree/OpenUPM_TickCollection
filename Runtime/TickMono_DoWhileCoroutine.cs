using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Tick
{

public class TickMono_DoWhileCoroutine : TickMono_AbstractDefault
{

    public float m_secondsBetweenTicks= 1;
    private void OnEnable()
    {
        StartCoroutine(DoWhileCoroutine());
    }

    private IEnumerator DoWhileCoroutine()
    {
            bool exit=false;
        do
        {
            base.TriggerTick();
            yield return new WaitForSeconds(m_secondsBetweenTicks);
            if (m_secondsBetweenTicks <= 0)
                yield return new WaitForEndOfFrame();
            base.TriggerTick();
        } while (!exit);
        yield return new WaitForSeconds(0);
    }

}

}