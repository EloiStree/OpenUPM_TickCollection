using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickMono_DoWhileCoroutineRandomBetween : TickMono_AbstractDefault
{

    public float m_secondsBetweenTicksMinimum = 0.1f;
    public float m_secondsBetweenTicksMaximum = 4;
    private void OnEnable()
    {
        StartCoroutine(DoWhileCoroutine());
    }

    private IEnumerator DoWhileCoroutine()
    {
        do
        {
            base.TriggerTick();
            float randomWait = Random.Range(m_secondsBetweenTicksMinimum, m_secondsBetweenTicksMaximum);
            yield return new WaitForSeconds(randomWait);
            if (randomWait <= 0)
                yield return new WaitForEndOfFrame();
            base.TriggerTick();
        } while (true);
    }

}
