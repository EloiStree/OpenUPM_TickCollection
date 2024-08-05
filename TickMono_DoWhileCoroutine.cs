using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickMono_DoWhileCoroutine : TickMono_AbstractDefault
{

    public float m_secondsBetweenTicks= 1;
    private void OnEnable()
    {
        StartCoroutine(DoWhileCoroutine());
    }

    private IEnumerator DoWhileCoroutine()
    {
        do
        {
            base.TriggerTick();
            yield return new WaitForSeconds(m_secondsBetweenTicks);
            if (m_secondsBetweenTicks <= 0)
                yield return new WaitForEndOfFrame();
            base.TriggerTick();
        } while (true);
    }

}
