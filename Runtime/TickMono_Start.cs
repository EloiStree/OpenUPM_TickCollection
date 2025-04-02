using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Eloi.Tick
{

public class TickMono_Start : MonoBehaviour
{

    public UnityEvent m_onTick;
    void Start()
    {
        m_onTick.Invoke();   
    }

}

}