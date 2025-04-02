using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Tick
{

public class TickMono_Delay : TickMono_AbstractDefault
{
    public bool m_fromStart=true;
    public bool m_fromEnable=false;

    public float m_delayTimeInSeconds = 1.0f;
    void Start()
    {
        if(m_fromStart)
            Invoke("OnTick", m_delayTimeInSeconds);
    }

    private void OnEnable()
    {
        if(m_fromEnable)
            Invoke("OnTick", m_delayTimeInSeconds);
    }

    public void OnTick()
    {
        base.TriggerTick();
    }

    public void InvokeTickWithDelay()
    {

        Invoke("OnTick", m_delayTimeInSeconds);
    }
    public void InvokeTickWithDelay(float delayInSeconds)
    {
        Invoke("OnTick", delayInSeconds);
    }
}

}